namespace TicketAppV2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusBar = new System.Windows.Forms.TextBox();
            this.InputBar = new System.Windows.Forms.TextBox();
            this.Sell = new System.Windows.Forms.Button();
            this.Use = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.LogClear = new System.Windows.Forms.Button();
            this.Wipe = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Button();
            this.Regenerate = new System.Windows.Forms.Button();
            this.InfoBar = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchNumber = new System.Windows.Forms.Button();
            this.AllTickets = new System.Windows.Forms.RichTextBox();
            this.error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.systemTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(206, 9);
            this.StatusBar.Multiline = true;
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.ReadOnly = true;
            this.StatusBar.Size = new System.Drawing.Size(344, 305);
            this.StatusBar.TabIndex = 1;
            // 
            // InputBar
            // 
            this.InputBar.Location = new System.Drawing.Point(206, 350);
            this.InputBar.Multiline = true;
            this.InputBar.Name = "InputBar";
            this.InputBar.Size = new System.Drawing.Size(344, 25);
            this.InputBar.TabIndex = 2;
            this.InputBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputEnter);
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(292, 412);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(82, 25);
            this.Sell.TabIndex = 3;
            this.Sell.Text = "Sell";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Button_Click);
            // 
            // Use
            // 
            this.Use.Location = new System.Drawing.Point(292, 381);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(82, 25);
            this.Use.TabIndex = 11;
            this.Use.Text = "Use";
            this.Use.UseVisualStyleBackColor = true;
            this.Use.Click += new System.EventHandler(this.Button_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(380, 381);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 25);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Button_Click);
            // 
            // LogClear
            // 
            this.LogClear.Location = new System.Drawing.Point(468, 381);
            this.LogClear.Name = "LogClear";
            this.LogClear.Size = new System.Drawing.Size(82, 25);
            this.LogClear.TabIndex = 13;
            this.LogClear.Text = "Log Clear";
            this.LogClear.UseVisualStyleBackColor = true;
            this.LogClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // Wipe
            // 
            this.Wipe.Location = new System.Drawing.Point(206, 381);
            this.Wipe.Name = "Wipe";
            this.Wipe.Size = new System.Drawing.Size(80, 25);
            this.Wipe.TabIndex = 16;
            this.Wipe.Text = "Wipe";
            this.Wipe.UseVisualStyleBackColor = true;
            this.Wipe.Click += new System.EventHandler(this.Button_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(380, 412);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(82, 25);
            this.Status.TabIndex = 17;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.Click += new System.EventHandler(this.Button_Click);
            // 
            // Regenerate
            // 
            this.Regenerate.Location = new System.Drawing.Point(12, 381);
            this.Regenerate.Name = "Regenerate";
            this.Regenerate.Size = new System.Drawing.Size(188, 25);
            this.Regenerate.TabIndex = 18;
            this.Regenerate.Text = "Regenerate";
            this.Regenerate.UseVisualStyleBackColor = true;
            this.Regenerate.Click += new System.EventHandler(this.Button_Click);
            // 
            // InfoBar
            // 
            this.InfoBar.Location = new System.Drawing.Point(206, 320);
            this.InfoBar.Multiline = true;
            this.InfoBar.Name = "InfoBar";
            this.InfoBar.ReadOnly = true;
            this.InfoBar.Size = new System.Drawing.Size(344, 24);
            this.InfoBar.TabIndex = 24;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(468, 412);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(82, 25);
            this.QuitButton.TabIndex = 25;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(206, 412);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(80, 25);
            this.Load.TabIndex = 26;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Button_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(11, 412);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(189, 25);
            this.Save.TabIndex = 27;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Button_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(12, 320);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(190, 24);
            this.SearchBar.TabIndex = 28;
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownSearchBar);
            // 
            // SearchNumber
            // 
            this.SearchNumber.Location = new System.Drawing.Point(12, 350);
            this.SearchNumber.Name = "SearchNumber";
            this.SearchNumber.Size = new System.Drawing.Size(188, 25);
            this.SearchNumber.TabIndex = 30;
            this.SearchNumber.Text = "Search Number";
            this.SearchNumber.UseVisualStyleBackColor = true;
            this.SearchNumber.Click += new System.EventHandler(this.Button_Click);
            // 
            // AllTickets
            // 
            this.AllTickets.BackColor = System.Drawing.SystemColors.Control;
            this.AllTickets.Location = new System.Drawing.Point(12, 9);
            this.AllTickets.Name = "AllTickets";
            this.AllTickets.ReadOnly = true;
            this.AllTickets.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AllTickets.Size = new System.Drawing.Size(188, 289);
            this.AllTickets.TabIndex = 31;
            this.AllTickets.Text = "";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(208, 325);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // systemTime
            // 
            this.systemTime.AutoSize = true;
            this.systemTime.Location = new System.Drawing.Point(13, 301);
            this.systemTime.Name = "systemTime";
            this.systemTime.Size = new System.Drawing.Size(33, 13);
            this.systemTime.TabIndex = 33;
            this.systemTime.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 447);
            this.Controls.Add(this.systemTime);
            this.Controls.Add(this.error);
            this.Controls.Add(this.AllTickets);
            this.Controls.Add(this.SearchNumber);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.InfoBar);
            this.Controls.Add(this.Regenerate);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Wipe);
            this.Controls.Add(this.LogClear);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.InputBar);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ticket App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StatusBar;
        private System.Windows.Forms.TextBox InputBar;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Regenerate;
        private System.Windows.Forms.Button Status;
        private System.Windows.Forms.Button Wipe;
        private System.Windows.Forms.Button LogClear;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Use;
        private System.Windows.Forms.TextBox InfoBar;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchNumber;
        private System.Windows.Forms.RichTextBox AllTickets;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label systemTime;
    }
}

