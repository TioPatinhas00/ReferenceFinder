namespace ReferenceFinder.View
{
    partial class Chat
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
            this.ListChat = new System.Windows.Forms.ListBox();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListChat
            // 
            this.ListChat.FormattingEnabled = true;
            this.ListChat.ItemHeight = 20;
            this.ListChat.Location = new System.Drawing.Point(18, 18);
            this.ListChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListChat.Name = "ListChat";
            this.ListChat.Size = new System.Drawing.Size(1162, 604);
            this.ListChat.TabIndex = 0;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Location = new System.Drawing.Point(18, 643);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(1040, 26);
            this.TxtReferencia.TabIndex = 1;
            this.TxtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReferencia_KeyPress);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(1070, 638);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(112, 35);
            this.BtnEnviar.TabIndex = 2;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtReferencia);
            this.Controls.Add(this.ListChat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListChat;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.Button BtnEnviar;
    }
}