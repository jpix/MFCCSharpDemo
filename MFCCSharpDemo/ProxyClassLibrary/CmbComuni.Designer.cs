﻿namespace ProxyClassLibrary
{
    partial class CmbComuni
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
            this.comuniDropDownList1 = new CFComponentN18.ComuniDropDownList.ComuniDropDownList(this.components);
            this.SuspendLayout();
            // 
            // comuniDropDownList1
            // 
            this.comuniDropDownList1.CodiceComune = null;
            this.comuniDropDownList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comuniDropDownList1.FormattingEnabled = true;
            this.comuniDropDownList1.Location = new System.Drawing.Point(5, 7);
            this.comuniDropDownList1.Name = "comuniDropDownList1";
            this.comuniDropDownList1.Provincia = null;
            this.comuniDropDownList1.Size = new System.Drawing.Size(557, 24);
            this.comuniDropDownList1.TabIndex = 0;
            // 
            // CmbComuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comuniDropDownList1);
            this.Name = "CmbComuni";
            this.Size = new System.Drawing.Size(565, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.ComuniDropDownList.ComuniDropDownList comuniDropDownList1;
    }
}
