Imports WpfKb.Controls

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)

        Dim Floater = New FloatingDocunetKeyboard() With {
            .AreAnimationsEnabled = True,
            .IsOpen = True,
            .Width = 900,
            .Height = 400,
            .IsDragHelperAllowedToHide = True
        }

    End Sub

End Class
