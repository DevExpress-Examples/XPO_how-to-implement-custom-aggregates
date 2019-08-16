Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace XpoCustomAggregate
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			ConnectionHelper.Connect()
			DemoDataHelper.Seed()
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
