
namespace Recreational_Centre
{
    partial class AdminForm
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
            this.PriceDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewPrice_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.holidayandweekdayGridView = new System.Windows.Forms.DataGridView();
            this.LoadExceptionButton = new System.Windows.Forms.Button();
            this.SaveExceptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayandweekdayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGridView
            // 
            this.PriceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGridView.Location = new System.Drawing.Point(35, 25);
            this.PriceDataGridView.Name = "PriceDataGridView";
            this.PriceDataGridView.Size = new System.Drawing.Size(754, 227);
            this.PriceDataGridView.TabIndex = 0;
            // 
            // ViewPrice_Button
            // 
            this.ViewPrice_Button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPrice_Button.Location = new System.Drawing.Point(35, 277);
            this.ViewPrice_Button.Name = "ViewPrice_Button";
            this.ViewPrice_Button.Size = new System.Drawing.Size(95, 30);
            this.ViewPrice_Button.TabIndex = 1;
            this.ViewPrice_Button.Text = "View Prices";
            this.ViewPrice_Button.UseVisualStyleBackColor = true;
            this.ViewPrice_Button.Click += new System.EventHandler(this.ViewPrice_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.Location = new System.Drawing.Point(162, 277);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(95, 30);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(278, 277);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(95, 30);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(405, 277);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(190, 30);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Display Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(619, 277);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(110, 30);
            this.LogOut_Button.TabIndex = 5;
            this.LogOut_Button.Text = "Log Out";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // holidayandweekdayGridView
            // 
            this.holidayandweekdayGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.holidayandweekdayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayandweekdayGridView.Location = new System.Drawing.Point(35, 337);
            this.holidayandweekdayGridView.Name = "holidayandweekdayGridView";
            this.holidayandweekdayGridView.Size = new System.Drawing.Size(754, 227);
            this.holidayandweekdayGridView.TabIndex = 6;
            // 
            // LoadExceptionButton
            // 
            this.LoadExceptionButton.Location = new System.Drawing.Point(44, 570);
            this.LoadExceptionButton.Name = "LoadExceptionButton";
            this.LoadExceptionButton.Size = new System.Drawing.Size(75, 23);
            this.LoadExceptionButton.TabIndex = 7;
            this.LoadExceptionButton.Text = "Load";
            this.LoadExceptionButton.UseVisualStyleBackColor = true;
            this.LoadExceptionButton.Click += new System.EventHandler(this.LoadExceptionButton_Click);
            // 
            // SaveExceptionButton
            // 
            this.SaveExceptionButton.Location = new System.Drawing.Point(146, 570);
            this.SaveExceptionButton.Name = "SaveExceptionButton";
            this.SaveExceptionButton.Size = new System.Drawing.Size(75, 23);
            this.SaveExceptionButton.TabIndex = 8;
            this.SaveExceptionButton.Text = "Save";
            this.SaveExceptionButton.UseVisualStyleBackColor = true;
            this.SaveExceptionButton.Click += new System.EventHandler(this.SaveExceptionButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 612);
            this.Controls.Add(this.SaveExceptionButton);
            this.Controls.Add(this.LoadExceptionButton);
            this.Controls.Add(this.holidayandweekdayGridView);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.ViewPrice_Button);
            this.Controls.Add(this.PriceDataGridView);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayandweekdayGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGridView;
        private System.Windows.Forms.Button ViewPrice_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.DataGridView holidayandweekdayGridView;
        private System.Windows.Forms.Button LoadExceptionButton;
        private System.Windows.Forms.Button SaveExceptionButton;
    }
}