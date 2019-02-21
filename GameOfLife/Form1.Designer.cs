namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.buttBuild = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttStart = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.tbTimerMS = new System.Windows.Forms.TextBox();
            this.buttStop = new System.Windows.Forms.Button();
            this.cbMouseDraw = new System.Windows.Forms.CheckBox();
            this.cbUseTimer = new System.Windows.Forms.CheckBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelMS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSize.Location = new System.Drawing.Point(67, 7);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(49, 22);
            this.tbSize.TabIndex = 0;
            this.tbSize.Text = "36";
            // 
            // buttBuild
            // 
            this.buttBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttBuild.Location = new System.Drawing.Point(13, 35);
            this.buttBuild.Name = "buttBuild";
            this.buttBuild.Size = new System.Drawing.Size(49, 25);
            this.buttBuild.TabIndex = 1;
            this.buttBuild.Text = "Zero";
            this.buttBuild.UseVisualStyleBackColor = true;
            this.buttBuild.Click += new System.EventHandler(this.buttBuild_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(140, -1);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.EmptyPointStyle.IsVisibleInLegend = false;
            series3.IsVisibleInLegend = false;
            series3.LabelForeColor = System.Drawing.Color.DimGray;
            series3.MarkerColor = System.Drawing.Color.DimGray;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Series1";
            series3.SmartLabelStyle.Enabled = false;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series4.IsVisibleInLegend = false;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Series2";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(330, 328);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // buttStart
            // 
            this.buttStart.Enabled = false;
            this.buttStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttStart.Location = new System.Drawing.Point(13, 67);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(109, 47);
            this.buttStart.TabIndex = 4;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = true;
            this.buttStart.Click += new System.EventHandler(this.buttStart_Click);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // tbTimerMS
            // 
            this.tbTimerMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimerMS.Location = new System.Drawing.Point(18, 190);
            this.tbTimerMS.Name = "tbTimerMS";
            this.tbTimerMS.Size = new System.Drawing.Size(61, 22);
            this.tbTimerMS.TabIndex = 5;
            this.tbTimerMS.Text = "50";
            // 
            // buttStop
            // 
            this.buttStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttStop.Location = new System.Drawing.Point(14, 66);
            this.buttStop.Name = "buttStop";
            this.buttStop.Size = new System.Drawing.Size(109, 47);
            this.buttStop.TabIndex = 6;
            this.buttStop.Text = "Stop";
            this.buttStop.UseVisualStyleBackColor = true;
            this.buttStop.Visible = false;
            this.buttStop.Click += new System.EventHandler(this.buttStop_Click);
            // 
            // cbMouseDraw
            // 
            this.cbMouseDraw.AutoSize = true;
            this.cbMouseDraw.Checked = true;
            this.cbMouseDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMouseDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMouseDraw.Location = new System.Drawing.Point(14, 120);
            this.cbMouseDraw.Name = "cbMouseDraw";
            this.cbMouseDraw.Size = new System.Drawing.Size(109, 20);
            this.cbMouseDraw.TabIndex = 7;
            this.cbMouseDraw.Text = "Allow drawing";
            this.cbMouseDraw.UseVisualStyleBackColor = true;
            // 
            // cbUseTimer
            // 
            this.cbUseTimer.AutoSize = true;
            this.cbUseTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUseTimer.Location = new System.Drawing.Point(25, 164);
            this.cbUseTimer.Name = "cbUseTimer";
            this.cbUseTimer.Size = new System.Drawing.Size(84, 20);
            this.cbUseTimer.TabIndex = 8;
            this.cbUseTimer.Text = "Use timer";
            this.cbUseTimer.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(20, 11);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(34, 16);
            this.labelSize.TabIndex = 9;
            this.labelSize.Text = "Size";
            // 
            // labelMS
            // 
            this.labelMS.AutoSize = true;
            this.labelMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMS.Location = new System.Drawing.Point(82, 193);
            this.labelMS.Name = "labelMS";
            this.labelMS.Size = new System.Drawing.Size(26, 16);
            this.labelMS.TabIndex = 10;
            this.labelMS.Text = "ms";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(68, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMS);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.cbUseTimer);
            this.Controls.Add(this.cbMouseDraw);
            this.Controls.Add(this.tbTimerMS);
            this.Controls.Add(this.buttBuild);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.buttStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button buttBuild;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttStart;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TextBox tbTimerMS;
        private System.Windows.Forms.Button buttStop;
        private System.Windows.Forms.CheckBox cbMouseDraw;
        private System.Windows.Forms.CheckBox cbUseTimer;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelMS;
        private System.Windows.Forms.Button button1;
    }
}

