using System;
using System.Windows;
using DevExpress.Xpf.Charts;

namespace ScatterLineChartWithCustomFunction {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            CreateArchimedianSpiralPoints();
        }

        void CreateArchimedianSpiralPoints() {
            for (int i = 0; i < 720; i += 15) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                ArchimedianSpiral.Points.Add(new SeriesPoint(x, y));
            }
        }
    }
}
