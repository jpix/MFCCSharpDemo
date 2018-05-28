namespace ProxyClassLibrary
{
    partial class CmbRegioni
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
            this.regioniDropDownList1 = new CFComponentN18.RegioniDropDownList.RegioniDropDownList(this.components);
            this.SuspendLayout();
            // 
            // regioniDropDownList1
            // 
            this.regioniDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regioniDropDownList1.FormattingEnabled = true;
            this.regioniDropDownList1.Location = new System.Drawing.Point(6, 7);
            this.regioniDropDownList1.Name = "regioniDropDownList1";
            this.regioniDropDownList1.Size = new System.Drawing.Size(257, 24);
            this.regioniDropDownList1.TabIndex = 0;
            // 
            // CmbRegioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.regioniDropDownList1);
            this.Name = "CmbRegioni";
            this.Size = new System.Drawing.Size(266, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.RegioniDropDownList.RegioniDropDownList regioniDropDownList1;
    }
}
