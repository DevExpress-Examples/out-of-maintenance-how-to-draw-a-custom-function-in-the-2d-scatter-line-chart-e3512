Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace ScatterLineChartWithCustomFunction

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            CreateArchimedianSpiralPoints()
        End Sub

        Private Sub CreateArchimedianSpiralPoints()
            For i As Integer = 0 To 720 - 1 Step 15
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = t * Math.Cos(t)
                Dim y As Double = t * Math.Sin(t)
                Me.ArchimedianSpiral.Points.Add(New SeriesPoint(x, y))
            Next
        End Sub
    End Class
End Namespace
