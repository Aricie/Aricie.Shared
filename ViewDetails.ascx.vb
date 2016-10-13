Imports DotNetNuke.Framework.Providers
Imports DotNetNuke.Services.Localization
Imports DotNetNuke.Entities.Modules

Imports Aricie.Services
Imports Aricie.Shared.Components
Imports Aricie.DNN.Services

Imports System.IO
Imports System.Configuration
Imports System.Web.Configuration
Imports System.Data.SqlClient

Partial Public Class ViewDetails
    Inherits DotNetNuke.Entities.Modules.PortalModuleBase

#Region "Constants"

    Private Const CONFIGFILE_NAME As String = "Aricie.Modules.Liste.config"

#End Region

#Region "Private Properties"
    Private ReadOnly Property ConfigPath() As String
        Get
            Return System.IO.Path.Combine(MapPath(Me.TemplateSourceDirectory), CONFIGFILE_NAME)
        End Get
    End Property
#End Region

#Region "Event Handler"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            BindModuleList()
        End If
    End Sub

#End Region

#Region "Private Sub"

    Private Sub BindModuleList()
        Dim modList As ArrayList = Aricie.DNN.Services.NukeHelper.DesktopModuleController.GetDesktopModules
        Dim aricieModList As New List(Of AricieModuleInfo)

        If File.Exists(ConfigPath) Then
            Dim myReader As New StreamReader(ConfigPath)
            aricieModList = ReflectionHelper.Deserialize(Of List(Of AricieModuleInfo))(myReader.ReadToEnd)
            myReader.Close()
        End If

        For Each myMod As DesktopModuleInfo In modList
            If myMod.ModuleName.StartsWith("Aricie") Then
                For Each aricieMod As AricieModuleInfo In aricieModList
                    If myMod.ModuleName = aricieMod.ModuleName Then
                        aricieMod.Version = myMod.Version
                        aricieMod.FriendlyName = myMod.FriendlyName
                        aricieMod.Installed = True
                        Exit For
                    End If
                Next
            End If
        Next

        Mdl.DataSource = aricieModList
        Mdl.DataBind()

    End Sub

#End Region
    


End Class