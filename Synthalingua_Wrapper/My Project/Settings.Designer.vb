﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MainScriptLocation() As String
            Get
                Return CType(Me("MainScriptLocation"),String)
            End Get
            Set
                Me("MainScriptLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property AudioSource() As Integer
            Get
                Return CType(Me("AudioSource"),Integer)
            End Get
            Set
                Me("AudioSource") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property ProcDevice() As Integer
            Get
                Return CType(Me("ProcDevice"),Integer)
            End Get
            Set
                Me("ProcDevice") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2000")>  _
        Public Property WebServerPort() As Integer
            Get
                Return CType(Me("WebServerPort"),Integer)
            End Get
            Set
                Me("WebServerPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property WebServerEnabled() As Boolean
            Get
                Return CType(Me("WebServerEnabled"),Boolean)
            End Get
            Set
                Me("WebServerEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RamSize() As Integer
            Get
                Return CType(Me("RamSize"),Integer)
            End Get
            Set
                Me("RamSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ForceRam() As Boolean
            Get
                Return CType(Me("ForceRam"),Boolean)
            End Get
            Set
                Me("ForceRam") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property StreamLanguage() As String
            Get
                Return CType(Me("StreamLanguage"),String)
            End Get
            Set
                Me("StreamLanguage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnglishTranslationEnabled() As Boolean
            Get
                Return CType(Me("EnglishTranslationEnabled"),Boolean)
            End Get
            Set
                Me("EnglishTranslationEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SecondaryTranslationLang() As String
            Get
                Return CType(Me("SecondaryTranslationLang"),String)
            End Get
            Set
                Me("SecondaryTranslationLang") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecondaryTranslationEnabled() As Boolean
            Get
                Return CType(Me("SecondaryTranslationEnabled"),Boolean)
            End Get
            Set
                Me("SecondaryTranslationEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property HLSurl() As String
            Get
                Return CType(Me("HLSurl"),String)
            End Get
            Set
                Me("HLSurl") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property StreamChunkSize() As Integer
            Get
                Return CType(Me("StreamChunkSize"),Integer)
            End Get
            Set
                Me("StreamChunkSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HLSShowOriginal() As Boolean
            Get
                Return CType(Me("HLSShowOriginal"),Boolean)
            End Get
            Set
                Me("HLSShowOriginal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property MicrophoneEnergyThreshold() As Integer
            Get
                Return CType(Me("MicrophoneEnergyThreshold"),Integer)
            End Get
            Set
                Me("MicrophoneEnergyThreshold") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MicrophoneEnergyThresholdEnabled() As Boolean
            Get
                Return CType(Me("MicrophoneEnergyThresholdEnabled"),Boolean)
            End Get
            Set
                Me("MicrophoneEnergyThresholdEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property MicCalTime() As Integer
            Get
                Return CType(Me("MicCalTime"),Integer)
            End Get
            Set
                Me("MicCalTime") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MicCalTImeEnabled() As Boolean
            Get
                Return CType(Me("MicCalTImeEnabled"),Boolean)
            End Get
            Set
                Me("MicCalTImeEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property MicRecTimeout() As Integer
            Get
                Return CType(Me("MicRecTimeout"),Integer)
            End Get
            Set
                Me("MicRecTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MicRecTimeoutEnabled() As Boolean
            Get
                Return CType(Me("MicRecTimeoutEnabled"),Boolean)
            End Get
            Set
                Me("MicRecTimeoutEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property MicrophoneID() As Integer
            Get
                Return CType(Me("MicrophoneID"),Integer)
            End Get
            Set
                Me("MicrophoneID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CaptionsSaveLocation() As String
            Get
                Return CType(Me("CaptionsSaveLocation"),String)
            End Get
            Set
                Me("CaptionsSaveLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CookieName() As String
            Get
                Return CType(Me("CookieName"),String)
            End Get
            Set
                Me("CookieName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property PhraseTimeOut() As Integer
            Get
                Return CType(Me("PhraseTimeOut"),Integer)
            End Get
            Set
                Me("PhraseTimeOut") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PhraseTimeOutEnabled() As Boolean
            Get
                Return CType(Me("PhraseTimeOutEnabled"),Boolean)
            End Get
            Set
                Me("PhraseTimeOutEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Segoe UI, 21pt")>  _
        Public Property headertextlbl_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("headertextlbl_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("headertextlbl_font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("White")>  _
        Public Property headertextlbl_forecolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("headertextlbl_forecolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("headertextlbl_forecolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property headertextlbl_backcolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("headertextlbl_backcolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("headertextlbl_backcolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Segoe UI, 21pt")>  _
        Public Property translatedheaderlbl_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("translatedheaderlbl_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("translatedheaderlbl_font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("White")>  _
        Public Property translatedheaderlbl_forecolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("translatedheaderlbl_forecolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("translatedheaderlbl_forecolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property translatedheaderlbl_backcolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("translatedheaderlbl_backcolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("translatedheaderlbl_backcolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Segoe UI, 21pt")>  _
        Public Property transcribedheaderlbl_font() As Global.System.Drawing.Font
            Get
                Return CType(Me("transcribedheaderlbl_font"),Global.System.Drawing.Font)
            End Get
            Set
                Me("transcribedheaderlbl_font") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("White")>  _
        Public Property transcribedheaderlbl_forecolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("transcribedheaderlbl_forecolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("transcribedheaderlbl_forecolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property transcribedheaderlbl_backcolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("transcribedheaderlbl_backcolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("transcribedheaderlbl_backcolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property subwindow_lmode() As Boolean
            Get
                Return CType(Me("subwindow_lmode"),Boolean)
            End Get
            Set
                Me("subwindow_lmode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 177, 64")>  _
        Public Property subwindow_bgcolor() As Global.System.Drawing.Color
            Get
                Return CType(Me("subwindow_bgcolor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("subwindow_bgcolor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property WordBlockListEnabled() As Boolean
            Get
                Return CType(Me("WordBlockListEnabled"),Boolean)
            End Get
            Set
                Me("WordBlockListEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property RepeatProtection() As Boolean
            Get
                Return CType(Me("RepeatProtection"),Boolean)
            End Get
            Set
                Me("RepeatProtection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("blacklist.txt")>  _
        Public Property WordBlockListLocation() As String
            Get
                Return CType(Me("WordBlockListLocation"),String)
            End Get
            Set
                Me("WordBlockListLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CommandBlock() As String
            Get
                Return CType(Me("CommandBlock"),String)
            End Get
            Set
                Me("CommandBlock") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Portable")>  _
        Public Property ShortCutType() As String
            Get
                Return CType(Me("ShortCutType"),String)
            End Get
            Set
                Me("ShortCutType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PrimaryFolder() As String
            Get
                Return CType(Me("PrimaryFolder"),String)
            End Get
            Set
                Me("PrimaryFolder") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Synthalingua_Wrapper.My.MySettings
            Get
                Return Global.Synthalingua_Wrapper.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
