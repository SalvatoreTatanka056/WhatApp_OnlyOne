namespace WhatsApp_One.ControlsSuite
{
    partial class ConversationCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panelAddresses = new System.Windows.Forms.Panel();
            this.panelSplit = new System.Windows.Forms.Panel();
            this.gridConversationMessages = new System.Windows.Forms.DataGridView();
            this.LeftIndentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageBalloonOwnerDrawColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightIndentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConversationMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 89);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.panelInput.Size = new System.Drawing.Size(623, 97);
            this.panelInput.TabIndex = 61;
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(565, 70);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(54, 22);
            this.btnSend.TabIndex = 41;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.MaxLength = 0;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(623, 65);
            this.txtMessage.TabIndex = 10;
            // 
            // panelAddresses
            // 
            this.panelAddresses.BackColor = System.Drawing.Color.Navy;
            this.panelAddresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddresses.Location = new System.Drawing.Point(0, 0);
            this.panelAddresses.Name = "panelAddresses";
            this.panelAddresses.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.panelAddresses.Size = new System.Drawing.Size(623, 26);
            this.panelAddresses.TabIndex = 62;
            // 
            // panelSplit
            // 
            this.panelSplit.BackColor = System.Drawing.Color.Navy;
            this.panelSplit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSplit.Location = new System.Drawing.Point(0, 63);
            this.panelSplit.Name = "panelSplit";
            this.panelSplit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.panelSplit.Size = new System.Drawing.Size(623, 26);
            this.panelSplit.TabIndex = 63;
            // 
            // gridConversationMessages
            // 
            this.gridConversationMessages.AllowUserToAddRows = false;
            this.gridConversationMessages.AllowUserToDeleteRows = false;
            this.gridConversationMessages.AllowUserToResizeColumns = false;
            this.gridConversationMessages.AllowUserToResizeRows = false;
            this.gridConversationMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridConversationMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridConversationMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridConversationMessages.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridConversationMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridConversationMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridConversationMessages.ColumnHeadersVisible = false;
            this.gridConversationMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftIndentCol,
            this.MessageBalloonOwnerDrawColumn,
            this.RightIndentCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridConversationMessages.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridConversationMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConversationMessages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridConversationMessages.Location = new System.Drawing.Point(0, 26);
            this.gridConversationMessages.Name = "gridConversationMessages";
            this.gridConversationMessages.ReadOnly = true;
            this.gridConversationMessages.RowHeadersVisible = false;
            this.gridConversationMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridConversationMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConversationMessages.ShowCellErrors = false;
            this.gridConversationMessages.ShowEditingIcon = false;
            this.gridConversationMessages.ShowRowErrors = false;
            this.gridConversationMessages.Size = new System.Drawing.Size(623, 37);
            this.gridConversationMessages.TabIndex = 63;
            this.gridConversationMessages.VirtualMode = true;
            this.gridConversationMessages.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridConversationMessages_CellPainting);
            this.gridConversationMessages.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.gridConversationMessages_CellValueNeeded);
            this.gridConversationMessages.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridConversationMessages_NewRowNeeded);
            this.gridConversationMessages.RowHeightInfoNeeded += new System.Windows.Forms.DataGridViewRowHeightInfoNeededEventHandler(this.gridConversationMessages_RowHeightInfoNeeded);
            this.gridConversationMessages.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridConversationMessages_Scroll);
            // 
            // LeftIndentCol
            // 
            this.LeftIndentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LeftIndentCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.LeftIndentCol.HeaderText = "Left Indent";
            this.LeftIndentCol.Name = "LeftIndentCol";
            this.LeftIndentCol.ReadOnly = true;
            this.LeftIndentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LeftIndentCol.Width = 80;
            // 
            // MessageBalloonOwnerDrawColumn
            // 
            this.MessageBalloonOwnerDrawColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.MessageBalloonOwnerDrawColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.MessageBalloonOwnerDrawColumn.HeaderText = "Balloon Ownerdraw";
            this.MessageBalloonOwnerDrawColumn.Name = "MessageBalloonOwnerDrawColumn";
            this.MessageBalloonOwnerDrawColumn.ReadOnly = true;
            // 
            // RightIndentCol
            // 
            this.RightIndentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.RightIndentCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.RightIndentCol.HeaderText = "Right Indent";
            this.RightIndentCol.Name = "RightIndentCol";
            this.RightIndentCol.ReadOnly = true;
            this.RightIndentCol.Width = 80;
            // 
            // ConversationCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridConversationMessages);
            this.Controls.Add(this.panelAddresses);
            this.Controls.Add(this.panelSplit);
            this.Controls.Add(this.panelInput);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConversationCtrl";
            this.Size = new System.Drawing.Size(623, 186);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConversationMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        public  System.Windows.Forms.Button btnSend;
        public  System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel panelAddresses;
        private System.Windows.Forms.DataGridView gridConversationMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftIndentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageBalloonOwnerDrawColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightIndentCol;
        private System.Windows.Forms.Panel panelSplit;
    }
}
