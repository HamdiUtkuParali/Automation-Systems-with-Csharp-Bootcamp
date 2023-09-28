namespace ToDoList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxTaskDescAdd = new System.Windows.Forms.TextBox();
            this.lblTaskDescAdd = new System.Windows.Forms.Label();
            this.tbxTaskNameAdd = new System.Windows.Forms.TextBox();
            this.lblTaskNameAdd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxTaskNameDelete = new System.Windows.Forms.TextBox();
            this.tbxTaskDescDelete = new System.Windows.Forms.TextBox();
            this.lblTaskDescDelete = new System.Windows.Forms.Label();
            this.lblTaskNameDelete = new System.Windows.Forms.Label();
            this.dgwToDoList = new System.Windows.Forms.DataGridView();
            this.btnTaskComplete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDoList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 122);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.tbxTaskDescAdd);
            this.tabPage1.Controls.Add(this.lblTaskDescAdd);
            this.tabPage1.Controls.Add(this.tbxTaskNameAdd);
            this.tabPage1.Controls.Add(this.lblTaskNameAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(443, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 84);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxTaskDescAdd
            // 
            this.tbxTaskDescAdd.Location = new System.Drawing.Point(104, 59);
            this.tbxTaskDescAdd.Name = "tbxTaskDescAdd";
            this.tbxTaskDescAdd.Size = new System.Drawing.Size(261, 20);
            this.tbxTaskDescAdd.TabIndex = 3;
            // 
            // lblTaskDescAdd
            // 
            this.lblTaskDescAdd.AutoSize = true;
            this.lblTaskDescAdd.Location = new System.Drawing.Point(6, 62);
            this.lblTaskDescAdd.Name = "lblTaskDescAdd";
            this.lblTaskDescAdd.Size = new System.Drawing.Size(92, 13);
            this.lblTaskDescAdd.TabIndex = 2;
            this.lblTaskDescAdd.Text = "Görev Açıklaması:";
            // 
            // tbxTaskNameAdd
            // 
            this.tbxTaskNameAdd.Location = new System.Drawing.Point(104, 17);
            this.tbxTaskNameAdd.Name = "tbxTaskNameAdd";
            this.tbxTaskNameAdd.Size = new System.Drawing.Size(261, 20);
            this.tbxTaskNameAdd.TabIndex = 1;
            // 
            // lblTaskNameAdd
            // 
            this.lblTaskNameAdd.AutoSize = true;
            this.lblTaskNameAdd.Location = new System.Drawing.Point(6, 20);
            this.lblTaskNameAdd.Name = "lblTaskNameAdd";
            this.lblTaskNameAdd.Size = new System.Drawing.Size(57, 13);
            this.lblTaskNameAdd.TabIndex = 0;
            this.lblTaskNameAdd.Text = "Görev Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.tbxTaskNameDelete);
            this.tabPage2.Controls.Add(this.tbxTaskDescDelete);
            this.tabPage2.Controls.Add(this.lblTaskDescDelete);
            this.tabPage2.Controls.Add(this.lblTaskNameDelete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(443, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 84);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxTaskNameDelete
            // 
            this.tbxTaskNameDelete.Location = new System.Drawing.Point(104, 17);
            this.tbxTaskNameDelete.Name = "tbxTaskNameDelete";
            this.tbxTaskNameDelete.Size = new System.Drawing.Size(261, 20);
            this.tbxTaskNameDelete.TabIndex = 3;
            // 
            // tbxTaskDescDelete
            // 
            this.tbxTaskDescDelete.Location = new System.Drawing.Point(104, 59);
            this.tbxTaskDescDelete.Name = "tbxTaskDescDelete";
            this.tbxTaskDescDelete.Size = new System.Drawing.Size(261, 20);
            this.tbxTaskDescDelete.TabIndex = 2;
            // 
            // lblTaskDescDelete
            // 
            this.lblTaskDescDelete.AutoSize = true;
            this.lblTaskDescDelete.Location = new System.Drawing.Point(6, 62);
            this.lblTaskDescDelete.Name = "lblTaskDescDelete";
            this.lblTaskDescDelete.Size = new System.Drawing.Size(92, 13);
            this.lblTaskDescDelete.TabIndex = 1;
            this.lblTaskDescDelete.Text = "Görev Açıklaması:";
            // 
            // lblTaskNameDelete
            // 
            this.lblTaskNameDelete.AutoSize = true;
            this.lblTaskNameDelete.Location = new System.Drawing.Point(6, 20);
            this.lblTaskNameDelete.Name = "lblTaskNameDelete";
            this.lblTaskNameDelete.Size = new System.Drawing.Size(57, 13);
            this.lblTaskNameDelete.TabIndex = 0;
            this.lblTaskNameDelete.Text = "Görev Adı:";
            // 
            // dgwToDoList
            // 
            this.dgwToDoList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwToDoList.Location = new System.Drawing.Point(12, 141);
            this.dgwToDoList.Name = "dgwToDoList";
            this.dgwToDoList.Size = new System.Drawing.Size(592, 433);
            this.dgwToDoList.TabIndex = 1;
            this.dgwToDoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwToDoList_CellClick);
            // 
            // btnTaskComplete
            // 
            this.btnTaskComplete.Location = new System.Drawing.Point(459, 590);
            this.btnTaskComplete.Name = "btnTaskComplete";
            this.btnTaskComplete.Size = new System.Drawing.Size(145, 36);
            this.btnTaskComplete.TabIndex = 2;
            this.btnTaskComplete.Text = "Görevi Tamamla";
            this.btnTaskComplete.UseVisualStyleBackColor = true;
            this.btnTaskComplete.Click += new System.EventHandler(this.btnTaskComplete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 643);
            this.Controls.Add(this.btnTaskComplete);
            this.Controls.Add(this.dgwToDoList);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxTaskDescAdd;
        private System.Windows.Forms.Label lblTaskDescAdd;
        private System.Windows.Forms.TextBox tbxTaskNameAdd;
        private System.Windows.Forms.Label lblTaskNameAdd;
        private System.Windows.Forms.Label lblTaskDescDelete;
        private System.Windows.Forms.Label lblTaskNameDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxTaskNameDelete;
        private System.Windows.Forms.TextBox tbxTaskDescDelete;
        private System.Windows.Forms.DataGridView dgwToDoList;
        private System.Windows.Forms.Button btnTaskComplete;
    }
}

