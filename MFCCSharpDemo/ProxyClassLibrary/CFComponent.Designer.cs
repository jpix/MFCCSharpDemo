namespace ProxyClassLibrary
{
    partial class CfComponent
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
            this.cfComponent1 = new CFComponentN18.CFComponent(this.components);
            this.SuspendLayout();
            // 
            // cfComponent1
            // 
            this.cfComponent1.CognomeTextBox = null;
            this.cfComponent1.ComuniDropDownList = null;
            this.cfComponent1.DataNascitaPicker = null;
            this.cfComponent1.NomeTextBox = null;
            this.cfComponent1.ProvinceDropDownList = null;
            this.cfComponent1.RegioniDropDownList = null;
            this.cfComponent1.SessoDropDownList = null;
            // 
            // CFComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CFComponent";
            this.ResumeLayout(false);

        }

        #endregion

        private CFComponentN18.CFComponent cfComponent1;
    }
}
