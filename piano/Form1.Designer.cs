namespace piano
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_do = new System.Windows.Forms.Button();
            this.btn_re = new System.Windows.Forms.Button();
            this.btn_fa = new System.Windows.Forms.Button();
            this.btn_mi = new System.Windows.Forms.Button();
            this.btn_la = new System.Windows.Forms.Button();
            this.btn_sol = new System.Windows.Forms.Button();
            this.btn_doo = new System.Windows.Forms.Button();
            this.btn_si = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_replay = new System.Windows.Forms.Button();
            this.lb_playlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_musicname = new System.Windows.Forms.TextBox();
            this.tb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(151, 304);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(42, 85);
            this.btn_do.TabIndex = 0;
            this.btn_do.Text = "DO";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(213, 304);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(42, 85);
            this.btn_re.TabIndex = 1;
            this.btn_re.Text = "RE";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_fa
            // 
            this.btn_fa.Location = new System.Drawing.Point(336, 304);
            this.btn_fa.Name = "btn_fa";
            this.btn_fa.Size = new System.Drawing.Size(42, 85);
            this.btn_fa.TabIndex = 4;
            this.btn_fa.Text = "FA";
            this.btn_fa.UseVisualStyleBackColor = true;
            this.btn_fa.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_mi
            // 
            this.btn_mi.Location = new System.Drawing.Point(274, 304);
            this.btn_mi.Name = "btn_mi";
            this.btn_mi.Size = new System.Drawing.Size(42, 85);
            this.btn_mi.TabIndex = 3;
            this.btn_mi.Text = "MI";
            this.btn_mi.UseVisualStyleBackColor = true;
            this.btn_mi.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_la
            // 
            this.btn_la.Location = new System.Drawing.Point(462, 304);
            this.btn_la.Name = "btn_la";
            this.btn_la.Size = new System.Drawing.Size(42, 85);
            this.btn_la.TabIndex = 6;
            this.btn_la.Text = "LA";
            this.btn_la.UseVisualStyleBackColor = true;
            this.btn_la.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_sol
            // 
            this.btn_sol.Location = new System.Drawing.Point(400, 304);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(42, 85);
            this.btn_sol.TabIndex = 5;
            this.btn_sol.Text = "SOL";
            this.btn_sol.UseVisualStyleBackColor = true;
            this.btn_sol.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_doo
            // 
            this.btn_doo.Location = new System.Drawing.Point(589, 304);
            this.btn_doo.Name = "btn_doo";
            this.btn_doo.Size = new System.Drawing.Size(42, 85);
            this.btn_doo.TabIndex = 8;
            this.btn_doo.Text = "DOO";
            this.btn_doo.UseVisualStyleBackColor = true;
            this.btn_doo.Click += new System.EventHandler(this.tile_Click);
            // 
            // btn_si
            // 
            this.btn_si.Location = new System.Drawing.Point(527, 304);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(42, 85);
            this.btn_si.TabIndex = 7;
            this.btn_si.Text = "SI";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.tile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enregistrer";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(117, 62);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "start";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_replay
            // 
            this.btn_replay.Location = new System.Drawing.Point(241, 62);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(75, 23);
            this.btn_replay.TabIndex = 11;
            this.btn_replay.Text = "Replay";
            this.btn_replay.UseVisualStyleBackColor = true;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // lb_playlist
            // 
            this.lb_playlist.FormattingEnabled = true;
            this.lb_playlist.Location = new System.Drawing.Point(449, 62);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(267, 212);
            this.lb_playlist.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom morceau";
            // 
            // tb_musicname
            // 
            this.tb_musicname.Location = new System.Drawing.Point(117, 99);
            this.tb_musicname.Name = "tb_musicname";
            this.tb_musicname.Size = new System.Drawing.Size(100, 20);
            this.tb_musicname.TabIndex = 14;
            // 
            // tb_error
            // 
            this.tb_error.AutoSize = true;
            this.tb_error.Location = new System.Drawing.Point(53, 38);
            this.tb_error.Name = "tb_error";
            this.tb_error.Size = new System.Drawing.Size(0, 13);
            this.tb_error.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.tb_musicname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_playlist);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_doo);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_la);
            this.Controls.Add(this.btn_sol);
            this.Controls.Add(this.btn_fa);
            this.Controls.Add(this.btn_mi);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.btn_do);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.Button btn_fa;
        private System.Windows.Forms.Button btn_mi;
        private System.Windows.Forms.Button btn_la;
        private System.Windows.Forms.Button btn_sol;
        private System.Windows.Forms.Button btn_doo;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.ListBox lb_playlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_musicname;
        private System.Windows.Forms.Label tb_error;
    }
}

