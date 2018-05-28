namespace ProxyClassLibrary
{
    partial class TxtNome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nomeTextBox1 = new CFComponentN18.NomeTextBox.NomeTextBox(this.components);
            this.SuspendLayout();
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox1.Location = new System.Drawing.Point(6, 6);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.ShortcutsEnabled = false;
            this.nomeTextBox1.Size = new System.Drawing.Size(261, 22);
            this.nomeTextBox1.TabIndex = 0;
            // 
            // TxtNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nomeTextBox1);
            this.Name = "TxtNome";
            this.Size = new System.Drawing.Size(270, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CFComponentN18.NomeTextBox.NomeTextBox nomeTextBox1;
    }
}
