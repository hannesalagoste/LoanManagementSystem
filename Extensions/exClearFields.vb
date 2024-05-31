Imports System.Runtime.CompilerServices

Module ControlExtensions
    <Extension()>
    Public Sub ClearFields(ByVal control As Control)
        ' Iterate through all controls in the parent control.
        For Each ctrl As Control In control.Controls
            ' Clear fields based on control type.
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is ListBox Then
                CType(ctrl, ListBox).ClearSelected()
            ElseIf TypeOf ctrl Is NumericUpDown Then
                CType(ctrl, NumericUpDown).Value = CType(ctrl, NumericUpDown).Minimum
            End If

            ' Recursively clear fields in container controls.
            If ctrl.HasChildren Then
                ctrl.ClearFields()
            End If
        Next
    End Sub
End Module
