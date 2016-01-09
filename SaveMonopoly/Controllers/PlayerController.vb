﻿Imports System.Web.Mvc
Imports SaveMonopoly

Namespace Controllers
    Public Class PlayerController
        Inherits Controller

        Dim db As New DatabaseContainer

        ' GET: Player
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Player/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View(db.Players.Find(id))
        End Function

        ' GET: Player/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Player/Create
        '<HttpPost()>
        'Function Create(ByVal collection As FormCollection) As ActionResult
        '    ' TODO: Add insert logic here

        '    Return RedirectToAction("Index")

        'End Function

        <HttpPost()>
        Function Create(ByVal collection As Player) As ActionResult
            ' TODO: Add insert logic here

            db.Players.Add(collection)
            db.SaveChanges()

            Return RedirectToAction("Index")

        End Function

        ' GET: Player/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Player/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Player/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Player/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '************************************************************************
        'Function Login(ByVal player As String, password As String, ByVal collection As FormCollection) As ActionResult
        Function Login(ByVal player As String, password As String) As ActionResult
            Dim _Player = db.Players.FirstOrDefault(Function(x) x.name = player And x.password = password)

            If _Player Is Nothing Then
                Return RedirectToAction("Index")
            Else
                Return RedirectToAction("Details", New With {.id = _Player.Id})
            End If
        End Function
    End Class
End Namespace