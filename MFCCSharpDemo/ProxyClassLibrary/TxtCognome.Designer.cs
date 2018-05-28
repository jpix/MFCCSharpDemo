namespace ProxyClassLibrary
{
    partial class TxtCognome
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
            this.cognomeTextBox1 = new CFComponentN18.CognomeTextBox.CognomeTextBox(this.components);
            this.SuspendLayout();
            // 
            // cognomeTextBox1
            // 
            this.cognomeTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cognomeTextBox1.Location = new System.Drawing.Point(5, 7);
            this.cognomeTextBox1.Name = "cognomeTextBox1";
            this.cognomeTextBox1.ShortcutsEnabled = false;
            this.cognomeTextBox1.Size = new System.Drawing.Size(262, 22);
            this.cognomeTextBox1.TabIndex = 0;
            // 
            // TxtCognome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cognomeTextBox1);
            this.Name = "TxtCognome";
            this.Size = new System.Drawing.Size(270, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CFComponentN18.CognomeTextBox.CognomeTextBox cognomeTextBox1;
    }
}
