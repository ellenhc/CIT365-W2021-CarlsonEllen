
namespace MegaDesk_Carlson
{
    partial class MainMenu
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
            this.ButtonAddNew = new System.Windows.Forms.Button();
            this.ButtonViewQuotes = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddNew
            // 
            this.ButtonAddNew.Location = new System.Drawing.Point(12, 12);
            this.ButtonAddNew.Name = "ButtonAddNew";
            this.ButtonAddNew.Size = new System.Drawing.Size(100, 35);
            this.ButtonAddNew.TabIndex = 0;
            this.ButtonAddNew.Text = "&Add New Quote";
            this.ButtonAddNew.UseVisualStyleBackColor = true;
            this.ButtonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // ButtonViewQuotes
            // 
            this.ButtonViewQuotes.Location = new System.Drawing.Point(12, 63);
            this.ButtonViewQuotes.Name = "ButtonViewQuotes";
            this.ButtonViewQuotes.Size = new System.Drawing.Size(100, 35);
            this.ButtonViewQuotes.TabIndex = 1;
            this.ButtonViewQuotes.Text = "&View Quotes";
            this.ButtonViewQuotes.UseVisualStyleBackColor = true;
            this.ButtonViewQuotes.Click += new System.EventHandler(this.ButtonViewQuotes_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(12, 114);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(100, 35);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "&Search Quotes";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 164);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(100, 35);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonViewQuotes);
            this.Controls.Add(this.ButtonAddNew);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddNew;
        private System.Windows.Forms.Button ButtonViewQuotes;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonExit;
    }
}

