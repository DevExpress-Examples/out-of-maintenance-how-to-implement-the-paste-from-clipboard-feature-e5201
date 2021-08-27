<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629910/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5201)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Record.cs](./CS/Record.cs) (VB: [Record.vb](./VB/Record.vb))
<!-- default file list end -->
# How to implement the paste from clipboard feature


<p>It's possible to implement pasting multiple rows from clipboard to GridControl with the following approach:<br />- Detect Ctrl+V key combination in the GridControl.ProcessGridKey;<br />- Add the row data to GridControl if the corresponding row exists.</p>
<p><strong>Note:</strong> the GridControl supports the "copying to clipboard" feature out of the box. See the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_CopyToClipboardtopic">GridView.CopyToClipboard</a> method. To enable copying multiple row/cells, set the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnViewOptionsSelection_MultiSelecttopic">GridView.OptionsSelection.MultiSelect</a> to true and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridOptionsSelection_MultiSelectModetopic">GridView.OptionsSelection.MultiSelectMode</a> to <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridMultiSelectModeEnumtopic">CellSelect</a>.</p>
<p><strong>See Also:<br /></strong>- <a href="https://www.devexpress.com/Support/Center/p/E831">How to implement the Copy/Paste feature<br /></a>- <a href="https://www.devexpress.com/Support/Center/p/E863">How to copy selected rows to the clipboard</a></p>

<br/>


