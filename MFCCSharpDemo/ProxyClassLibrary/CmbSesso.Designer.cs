namespace ProxyClassLibrary
{
    partial class CmbSesso
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
            this.sessoDropDownList1 = new CFComponentN18.SessoDropDownList.SessoDropDownList(this.components);
            this.SuspendLayout();
            // 
            // sessoDropDownList1
            // 
            this.sessoDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessoDropDownList1.FormattingEnabled = true;
            this.sessoDropDownList1.Location = new System.Drawing.Point(5, 6);
            this.sessoDropDownList1.Name = "sessoDropDownList1";
            this.sessoDropDownList1.Size = new System.Drawing.Size(122, 24);
            this.sessoDropDownList1.TabIndex = 0;
            // 
            // CmbSesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sessoDropDownList1);
            this.Name = "CmbSesso";
            this.Size = new System.Drawing.Size(138, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.SessoDropDownList.SessoDropDownList sessoDropDownList1;
    }
}
