using POVLetters.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POVLetters
{
  public partial class Form1 : Form
  {
    private List<Panel> Panels;
    private const int InitialXOffset = 42;
    private const int InitialYOffset = 42;
    const int Cols = 8;
    const int Rows = 8;

    private List<string> Alphabet = new List<string>();
    private int CurrentLetter = -1;

    public Form1() {
      InitializeComponent();
      InitializePanels();
      CurrentLetter = 0;
      Alphabet.Add(string.Empty);
    }

    private void InitializePanels() {
      Panels = new List<Panel>();
      for (var row = 0; row < Rows; row++) {
        for (var col = 0; col < Cols; col++) {
          var panel = new Panel {
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point(col * 55 + InitialXOffset, row * 55 + InitialYOffset),
            Name = "panel" + row + "_" + col,
            Size = new Size(50, 50),
            TabIndex = 1,
            AllowDrop = true
          };
          panel.Click += panel1_Click;
          Panels.Add(panel);
          Controls.Add(panel);
        }
      }
    }

    private void panel1_Click(object sender, EventArgs e) {
      var panel = sender as Panel;
      if (panel == null) return;
      panel.BackColor = panel.BackColor == Color.Black ? DefaultBackColor : Color.Black;

      OutputText();
    }

    private void OutputText() {
      txtOutput.Text = String.Format("boolean {0} [][{1}] PROGMEM = ", txtLetterName.Text, Cols) + "{" + Environment.NewLine;
      for (var i = 0; i < Panels.Count; i++) {
        var panel = Panels[i];
        if (i % Cols == 0) {
          txtOutput.Text += "  { ";
        }
        if (panel.BackColor == Color.Black) txtOutput.Text += "1";
        else txtOutput.Text += "0";

        if (i % Cols == Cols - 1) {
          txtOutput.Text += " }";
          if (i != Cols * Rows - 1) txtOutput.Text += ",";
          txtOutput.Text += Environment.NewLine;
        } else {
          txtOutput.Text += ", ";
        }
      }
      txtOutput.Text += "};" + Environment.NewLine;
    }

    private void txtLetterName_TextChanged(object sender, EventArgs e) {
      OutputText();
    }

    private void btnNext_Click(object sender, EventArgs e) {
      if (txtLetterName.Text.IsNullOrWhiteSpace()) {
        MessageBox.Show("You must fill in the letter name first");
        return;
      }

      Alphabet[CurrentLetter] = txtOutput.Text;
      CurrentLetter++;
      LoadLetter();
    }

    private void LoadLetter() {
      if (Alphabet.Count > CurrentLetter) {
        if (CurrentLetter == -1) {
          Alphabet.Insert(0, string.Empty);
          CurrentLetter = 0;
          ClearValues();
        } else {
          var values = Alphabet[CurrentLetter].Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
          txtLetterName.Text = values[0].Split(' ')[1];
          var myRegex = new Regex(
            "([01])",
            RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );

          var results = myRegex.Matches(Alphabet[CurrentLetter]);
          for (var i = 0; i < results.Count; i++) {
            Panels[i].BackColor = results[i].ToString() == "1" ? Color.Black : DefaultBackColor;
          }
        }

      } else {
        if (Alphabet.Count != CurrentLetter) MessageBox.Show("Current Letter issue...");
        Alphabet.Add(string.Empty);
        ClearValues();
      }

      OutputText();
    }

    private void ClearValues() {
      txtOutput.Text = string.Empty;
      txtLetterName.Text = string.Empty;
      Panels.ForEach(panel => panel.BackColor = DefaultBackColor);
    }

    private void btnPrev_Click(object sender, EventArgs e) {
      if (txtLetterName.Text.IsNullOrWhiteSpace()) {
        MessageBox.Show("You must fill in the letter name first");
        return;
      }
      if (CurrentLetter == 0)
      {
        MessageBox.Show("You are already at the beginning");
        return;
      }

      Alphabet[CurrentLetter] = txtOutput.Text;
      CurrentLetter--;
      LoadLetter();
    }



    private void btnImport_Click(object sender, EventArgs e) {
      var ofd = new OpenFileDialog { Filter = "(*.txt)|*.txt" };
      if (ofd.ShowDialog() == DialogResult.OK) {
        var sb = new StringBuilder();
        using (var reader = new StreamReader(ofd.OpenFile())) {
          while (reader.Peek() != -1) {
            sb.Append(reader.ReadLine());
          }
        }

        var alphabet = sb.ToString();
        var regex = new Regex(
          "(boolean[\\s\\w\\d\\{\\}\\[\\]=,]+;)",
          RegexOptions.CultureInvariant
          | RegexOptions.Compiled
        );
        Alphabet.Clear();
        Alphabet = regex.Split(alphabet).Where(a => !a.IsNullOrWhiteSpace()).ToList();
        CurrentLetter = 0;
        LoadLetter();
      }

    }

    private void btnSave_Click(object sender, EventArgs e) {
      var sfd = new SaveFileDialog();
      sfd.Filter = "(*.txt)|*.txt";
      if (sfd.ShowDialog() == DialogResult.OK) {
        var stream = sfd.OpenFile();
        using (var writer = new StreamWriter(stream)) {
          foreach (var letter in Alphabet) {
            writer.WriteLine(letter);
          }

          writer.Flush();
          stream.Flush();
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      if (CurrentLetter > 0) {
        Alphabet.RemoveAt(CurrentLetter);
        CurrentLetter--;
        LoadLetter();
      } else if (CurrentLetter == 0 && Alphabet.Count > 1) {
        Alphabet.RemoveAt(CurrentLetter);
        LoadLetter();
      } else {
        ClearValues();
      }
    }
  }
}