<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FullCalendarControl.ascx.cs" Inherits="UserControlDemo.FullCalendarControl" %>
 <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblDisplayText" Text="DoB"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:ImageButton ID="imgBtnCalender" runat="server" OnClick="imgBtnCalender_Click" ImageUrl="~/Images/images.png" Height="30px" Width="27px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Calendar ID="calDate" runat="server" Visible="false" OnSelectionChanged="calDate_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
            </table>
    </div>