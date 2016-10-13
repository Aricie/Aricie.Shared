
Namespace Components

    <Serializable()> _
    Public Class AricieModuleInfo
        Private _ModuleName As String
        Private _Version As String
        Private _Installed As Boolean
        Private _FriendlyName As String

        Public Property ModuleName() As String
            Get
                Return _ModuleName
            End Get
            Set(ByVal value As String)
                _ModuleName = value
            End Set
        End Property

        Public Property FriendlyName() As String
            Get
                Return _FriendlyName
            End Get
            Set(ByVal value As String)
                _FriendlyName = value
            End Set
        End Property

        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal value As String)
                _Version = value
            End Set
        End Property

        Public Property Installed() As Boolean
            Get
                Return _Installed
            End Get
            Set(ByVal value As Boolean)
                _Installed = value
            End Set
        End Property


    End Class

End Namespace