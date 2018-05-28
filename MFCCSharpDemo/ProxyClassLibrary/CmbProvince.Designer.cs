namespace ProxyClassLibrary
{
    partial class CmbProvince
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
            this.provinceDropDownList1 = new CFComponentN18.ProvinceDropDownList.ProvinceDropDownList(this.components);
            this.SuspendLayout();
            // 
            // provinceDropDownList1
            // 
            this.provinceDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceDropDownList1.FormattingEnabled = true;
            this.provinceDropDownList1.Location = new System.Drawing.Point(5, 7);
            this.provinceDropDownList1.Name = "provinceDropDownList1";
            this.provinceDropDownList1.Size = new System.Drawing.Size(265, 24);
            this.provinceDropDownList1.TabIndex = 0;
            // 
            // CmbProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.provinceDropDownList1);
            this.Name = "CmbProvince";
            this.Size = new System.Drawing.Size(276, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.ProvinceDropDownList.ProvinceDropDownList provinceDropDownList1;
    }
}
