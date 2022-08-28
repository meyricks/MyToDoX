using System;
using System.Windows.Forms;

namespace CodeMax_POS
{
    public class InputBox
    {
        public static DialogResult pass(string título, string promptText, ref string value)
        {
            Form formulario = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            formulario.Text = título;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            textBox.UseSystemPasswordChar = true;
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            formulario.ClientSize = new System.Drawing.Size(396, 107);
            formulario.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            formulario.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), formulario.ClientSize.Height);
            formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
            formulario.MaximizeBox = false;
            formulario.AcceptButton = buttonOk;
            formulario.CancelButton = buttonCancel;

            DialogResult dialogResult = formulario.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public static DialogResult Text(string título, string promptText, ref string value)
        {
            Form formulario = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            formulario.Text = título;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            textBox.UseSystemPasswordChar = false;
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            formulario.ClientSize = new System.Drawing.Size(396, 107);
            formulario.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            formulario.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), formulario.ClientSize.Height);
            formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
            formulario.MaximizeBox = false;
            formulario.AcceptButton = buttonOk;
            formulario.CancelButton = buttonCancel;

            DialogResult dialogResult = formulario.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
