namespace ProxyClassLibrary
{
    partial class DtNascitaPicker
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
            this.dataNascitaPicker1 = new CFComponentN18.DataNascitaPicker.DataNascitaPicker(this.components);
            this.SuspendLayout();
            // 
            // dataNascitaPicker1
            // 
            this.dataNascitaPicker1.Location = new System.Drawing.Point(6, 4);
            this.dataNascitaPicker1.Name = "dataNascitaPicker1";
            this.dataNascitaPicker1.Size = new System.Drawing.Size(256, 22);
            this.dataNascitaPicker1.TabIndex = 0;
            // 
            // DtNascitaPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNascitaPicker1);
            this.Name = "DtNascitaPicker";
            this.Size = new System.Drawing.Size(272, 34);
            
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.DataNascitaPicker.DataNascitaPicker dataNascitaPicker1;
    }
}
