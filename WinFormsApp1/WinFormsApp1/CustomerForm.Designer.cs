namespace WinFormsApp1
{
    partial class CustomerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 25;
            lstProducts.Location = new Point(27, 30);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(298, 404);
            lstProducts.TabIndex = 0;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(lstProducts);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
    }
}