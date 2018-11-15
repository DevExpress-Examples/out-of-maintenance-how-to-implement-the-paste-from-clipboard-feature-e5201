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


