'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.296
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SubServer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property background() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property cbLeft() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cbLeft", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property cbRight() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cbRight", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property CloseEnter1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CloseEnter1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property CloseLeave1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CloseLeave1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property coin() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("coin", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property fButtonDark() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("fButtonDark", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property fButtonLight() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("fButtonLight", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property FormBack2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("FormBack2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property LoginBlack() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("LoginBlack", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property LoginWhite() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("LoginWhite", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property MouseSelect() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("MouseSelect", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property navbar00() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("navbar00", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property navbar2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("navbar2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property sci_fi() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("sci_fi", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property selectitem() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("selectitem", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property StatusBar() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StatusBar", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property TopNavBar() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TopNavBar", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
