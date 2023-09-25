Imports DevExpress.XtraBars.Ribbon

Namespace Dashboard_AggrSalesByMonths

    Public Partial Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()
            dashboardDesigner1.LoadDashboard("..\..\Data\SalesByMonths.xml")
        End Sub
    End Class
End Namespace
