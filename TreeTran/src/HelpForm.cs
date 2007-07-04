//**************************************************************************
// File: "TreeTran\HelpForm.cs".
//
// This file defines the HelpForm class, which implements a form that
// displays user-help documentation.
//
// History:
//     2007-Feb-21 David Bullock: Code complete.
//**************************************************************************
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
//**************************************************************************
namespace TreeTran
{
	//**********************************************************************
	/// <summary>
	/// Implements a form that displays user-help documentation.
	/// </summary>
	public class HelpForm: System.Windows.Forms.Form
	{
		//******************************************************************
		#region [Generated Code]
		//******************************************************************
		private System.Windows.Forms.RichTextBox moRichTextBox;
		// <summary>
		// Required designer variable.
		// </summary>
		private System.ComponentModel.Container components = null;

		// <summary>
		// Clean up any resources being used.
		// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		// <summary>
		// Required method for Designer support - do not modify
		// the contents of this method with the code editor.
		// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HelpForm));
			this.moRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			//
			// moRichTextBox
			//
			this.moRichTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.moRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.moRichTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
			this.moRichTextBox.Name = "moRichTextBox";
			this.moRichTextBox.ReadOnly = true;
			this.moRichTextBox.Size = new System.Drawing.Size(292, 274);
			this.moRichTextBox.TabIndex = 0;
			this.moRichTextBox.Text = "";
			this.moRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moRichTextBox_KeyDown);
			//
			// HelpForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 274);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.moRichTextBox});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HelpForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "TreeTran Help";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.HelpForm_Closing);
			this.Load += new System.EventHandler(this.HelpForm_Load);
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		//******************************************************************
		#region [Constructor, Static Instance Property, OnClosed() Method]
		//******************************************************************
		/// <summary>
		/// The constructor is private so only one instance of this form
		/// will be loaded at a time. You can get this single instance from
		/// the Instance property.
		/// </summary>
		private HelpForm()
		{
			//**************************************************************
			// As required to support code generated by the Form Designer,
			// make InitializeComponent() the first call in the constructor.

			InitializeComponent();

			//**************************************************************
			// Only one instance of this form should be loaded at a time.

			Debug.Assert(moInstance == null);
		}
		//******************************************************************
		/// <summary>
		/// The single loaded instance of this form. This value is returned
		/// by the Instance property. If moInstance is null, the Instance
		/// property sets it to a new instance, created by the private
		/// constructor. When the form is closed, the OnClosed() method sets
		/// moInstance back to null.
		/// </summary>
		private static HelpForm moInstance = null;
		//******************************************************************
		/// <summary>
		/// Gets the single loaded instance of this form. (The private
		/// constructor is called to create this instance if one is not
		/// currently loaded.)
		/// </summary>
		public static HelpForm Instance
		{
			get
			{
				if (moInstance == null)
				{
					moInstance = new HelpForm();
				}
				return moInstance;
			}
		}
		//******************************************************************
		/// <summary>
		/// Sets moInstance back to null when the form is closed.
		/// </summary>
		protected override void OnClosed(EventArgs oArgs)
		{
			try
			{
				moInstance = null;
			}
			catch (Exception oException)
			{
				ShowException(oException);
			}
		}
		#endregion
		//******************************************************************
		#region [T(), B() and P() Methods]
		//******************************************************************
		/// <summary>
		/// Appends the given string to the RichTextBox as regular text.
		/// </summary>
		private void T(string sString)
		{
			Font oFont = new Font(moRichTextBox.Font,FontStyle.Regular);
			moRichTextBox.Select(moRichTextBox.TextLength,0);
			moRichTextBox.SelectionFont = oFont;
			moRichTextBox.AppendText(sString);
			moRichTextBox.Select(0,0);
		}
		//******************************************************************
		/// <summary>
		/// Appends the given string to the RichTextBox as bold text.
		/// </summary>
		private void B(string sString)
		{
			Font oFont = new Font(moRichTextBox.Font,FontStyle.Bold);
			moRichTextBox.Select(moRichTextBox.TextLength,0);
			moRichTextBox.SelectionFont = oFont;
			moRichTextBox.AppendText(sString);
			moRichTextBox.Select(0,0);
		}
		//******************************************************************
		/// <summary>
		/// Appends a paragraph break to the RichTextBox.
		/// </summary>
		private void P()
		{
			moRichTextBox.AppendText(
				Environment.NewLine + Environment.NewLine);
			moRichTextBox.Select(0,0);
		}
		#endregion
		//******************************************************************
		#region [SetHelpText() Method]
		//******************************************************************
		/// <summary>
		/// Populates the RichTextBox with help information.
		/// </summary>
		private void SetHelpText()
		{
			//**************************************************************

			B("Brief Help for TreeTran");
			P();

			T("The TreeTran program provides a visual user interface ");
			T("that allows you to view parse trees, copy and paste ");
			T("branches to create and edit transfer rules, and then ");
			T("apply transfer rules to highlight the changes they make ");
			T("to example parse trees. ");
			T("The TreeTran program also provides a batch mode to apply ");
			T("transfer rules to an entire file of parse trees.");
			P();

			//**************************************************************

			B("Command Line");
			P();

			T("The TreeTran program can be run in interactive mode to ");
			T("create, edit and debug a file of tree-transfer rules, ");
			T("using the following command-line arguments:");
			P();

			B("TreeTran.exe");
			T(" [ rules.xml [ parses.xml ] ]");
			P();

			T("where ");
			B("rules.xml");
			T(" is the file of tree-transfer rules to edit, and ");
			B("parses.xml");
			T(" is an input file of parse trees (formatted according to ");
			T("the xample.dtd and pcpatr.dtd specifications). ");
			T("The optional file of parse trees is loaded so you can ");
			T("copy parts of the parse trees to use as transfer rules, ");
			T("and so you can debug transfer rules by stepping through ");
			T("their application to example parse trees.");
			P();

			T("The TreeTran program can also be run in batch mode to ");
			T("process an entire parse file by applying a set of ");
			T("transfer rules, using the following command-line ");
			T("arguments:");
			P();

			B("TreeTran.exe");
			T(" rules.xml parses.xml output.xml");
			P();

			T("where ");
			B("rules.xml");
			T(" is the file of tree-transfer rules to use, ");
			B("parses.xml");
			T(" is the input file of parse trees, and ");
			B("output.xml");
			T(" is the name of the output file to which parse trees will ");
			T("be written after they have been modified by the ");
			T("tree-transfer rules.");
			P();

			//**************************************************************

			B("TreeTran Window");
			P();

			T("The main TreeTran window contains two child windows: one ");
			T("that displays transfer rules, and one that displays ");
			T("parses.");
			P();

			T("The Rule window displays a list of rules in the panel on ");
			T("the left side of the window. ");
			T("The selected rule is displayed in two panels on the right ");
			T("side of the window. ");
			T("Each rule consists of two trees: a Find Pattern tree and ");
			T("a Replace Pattern tree.");
			P();

			T("The Parse window displays a list of parses in the panel ");
			T("on the left side of the window. ");
			T("The selected parse tree is displayed in a panel on the ");
			T("right side of the window.");
			P();

			T("In the lists, items can be selected using the direction ");
			T("keys (plus the Shift or Ctrl keys and the Spacebar to ");
			T("select multiple items). ");
			T("In the trees, nodes can be selected using the Home, End ");
			T("and arrow keys (plus the Ctrl key to modify the meanings ");
			T("of these keys).");
			P();

			//**************************************************************

			B("File Menu");
			P();

			T("The ");
			B("Open Rule File");
			T(" menu opens an xml file containing transfer rules.");
			P();

			T("The ");
			B("Save Rule File");
			T(" menu saves the displayed transfer rules to the same file ");
			T("as they were loaded from or saved to before.");
			P();

			T("The ");
			B("Save Rule File As");
			T(" menu saves the displayed transfer rules to a new file.");
			P();

			T("The ");
			B("Load Parse File");
			T(" menu opens an xml file containing parse trees.");
			P();

			T("The ");
			B("Save Parse File As");
			T(" menu saves the displayed parse trees to a new file.");
			P();

			T("The ");
			B("Process Parse File");
			T(" menu applies the displayed transfer rules to each of the ");
			T("parses in the file you select, and then saves the changes ");
			T("to a new file.");
			P();

			T("The ");
			B("Exit");
			T(" menu closes the TreeTran program.");
			P();

			//**************************************************************

			B("Edit Menu");
			P();

			T("The ");
			B("Undo");
			T(" menu undoes the last edit operation.");
			P();

			T("The ");
			B("Cut");
			T(" menu cuts the selected node or list item to the ");
			T("clipboard.");
			P();

			T("The ");
			B("Copy");
			T(" menu copies the selected node or list item to the ");
			T("clipboard.");
			P();

			T("The ");
			B("Paste");
			T(" menu pastes the node or list item from the clipboard. ");
			T("When you paste a node, you append the branch on the ");
			T("clipboard as a child of the selected node. ");
			T("(If the selected node is blank, you replace the node with ");
			T("the branch on the clipboard). ");
			T("When you paste into a list, the new items are inserted ");
			T("before the selected item in the list (or at the end of ");
			T("the list if no items are selected).");
			P();

			T("The ");
			B("Delete");
			T(" menu deletes the selected node or list item.");
			P();

			T("The ");
			B("Features");
			T(" menu opens the Features window, which lets you edit the ");
			T("features of the selected node. ");
			T("(Double-clicking a node also opens the Features window.)");
			P();

			//**************************************************************

			B("View Menu");
			P();

			T("The ");
			B("Show Features");
			T(" menu toggles the display of features in the parse tree.");
			P();

			T("The ");
			B("Show Morphology");
			T(" menu toggles the display of morphology in the parse tree.");
			P();

			T("The ");
			B("Font");
			T(" menu changes the font used to display the lists and ");
			T("trees.");
			P();

			//**************************************************************

			B("Rule Menu");
			P();

			T("The ");
			B("Find Matching Branch");
			T(" menu finds the next sub-tree that matches a Find ");
			T("Pattern. ");
			T("(You can also use the ");
			B("Find!");
			T(" menu or the F2 key to do the same thing.)");
			P();

			T("The ");
			B("Replace Matching Branch");
			T(" menu replaces the matching sub-tree with the nodes ");
			T("specified by the Replace Pattern. ");
			T("(You can also use the ");
			B("Replace!");
			T(" menu or the F3 key to do the same thing.)");
			P();

			T("The ");
			B("Find Only with Current Rule");
			T(" menu checks or unchecks this menu so the search for a ");
			T("matching sub-tree will use all rules or only the current ");
			T("rule.");
			P();

			T("The ");
			B("Find Only in Current Parse");
			T(" menu checks or unchecks this menu so the search for a ");
			T("matching sub-tree will look in all parses or only in the ");
			T("current parse.");
			P();

			T("The ");
			B("New Rule");
			T(" menu appends a new rule to the list of transfer rules.");
			P();

			T("The ");
			B("Rename");
			T(" menu lets you rename the current rule in the list of ");
			T("transfer rules.");
			P();

			//**************************************************************

			B("Window Menu");
			P();

			T("Provides ");
			B("Cascade");
			T(", ");
			B("Tile Horizontally");
			T(" and ");
			B("Tile Vertically");
			T(" operations for arranging the windows, as well as a list ");
			T("of open windows.");
			P();

			//**************************************************************

			B("Help Menu");
			P();

			T("Displays the program's version information or this brief ");
			T("help documentation. ");
			T("You can close the help window by pressing the Esc key.");
			P();

			//**************************************************************

			B("Features Window");
			P();

			T("You can edit node features by double-clicking the node ");
			T("(or by clicking the ");
			B("Features");
			T(" menu), which brings up the Features window.");
			P();

			T("In the Features window, the ");
			B("Label");
			T(" text box lets you edit the node's label. ");
			T("By default the label is the same as the node's category, ");
			T("but a number will automatically be appended (for example, ");
			T("\"PP#3\") if a node is pasted into a pattern where that ");
			T("label already exists. ");
			T("Find Pattern and Replace Pattern nodes correspond if they ");
			T("have the same label.");
			P();

			T("The ");
			B("Optional node");
			T(" check box indicates whether the node is optional or not. ");
			T("The label of an optional node begins with an open ");
			T("parenthesis (for example, \"(DP)\").");
			P();

			T("The ");
			B("Name");
			T(" / ");
			B("Value");
			T(" list box displays the node's features. ");
			T("(You can right-click in this list to cut, copy and paste ");
			T("the selected features.)");
			P();

			T("The ");
			B("Name");
			T(" text box lets you enter the name of a feature.");
			P();

			T("The ");
			B("Value");
			T(" text box lets you modify the value of the feature ");
			T("indicated by the ");
			B("Name");
			T(" text box. ");
			T("(You can press the Enter key in this text box to move ");
			T("back to the selected feature in the list box.)");
			P();

			T("The ");
			B("Delete");
			T(" button deletes the features selected in the list box.");
			P();

			T("The ");
			B("+");
			T(" and ");
			B("-");
			T(" buttons change the values of the selected features to + ");
			T("or -. ");
			T("(In the list box, you can also press the + or - keys to ");
			T("change values of the selected features.)");
			P();

			T("The ");
			B("OK");
			T(" button closes the Features window and saves the changes ");
			T("made to the node's features.");
			P();

			T("The ");
			B("Cancel");
			T(" button closes the Features window without saving the ");
			T("changes.");
			P();

			T("By clicking the ");
			B("More Options >>");
			T(" button, several additional controls are displayed:");
			P();

			T("The ");
			B("Filter");
			T(" text box allows you to enter a string, which restricts ");
			T("the list box so it only displays features with names ");
			T("containing that string.");
			P();

			T("The ");
			B("Show favorites only");
			T(" check box restricts the list box so it only displays ");
			T("features that have been marked as favorites.");
			P();

			T("The ");
			B("Show all favorites");
			T(" check box displays all features marked as favorites, ");
			T("including features that do not appear on this node. ");
			T("This can be useful for setting a new node feature or ");
			T("changing which features are marked as favorites.");
			P();

			T("The ");
			B("Favorite in list");
			T(" check box marks the selected features as a favorites.");
			P();

			T("The ");
			B("Show in tree");
			T(" check box marks features to be displayed in the ");
			T("parse-tree view.");
			P();

			T("The ");
			B("Copy favorites only");
			T(" check box indicates whether all features or only ");
			T("favorites will be copied to the clipboard when a sub-tree ");
			T("is cut or copied.");
			P();

			//**************************************************************

			B("Find Pattern");
			P();

			T("The TreeTran engine does a post-order (parent after its ");
			T("children) traversal of each parse tree, looking for a ");
			T("sub-tree that matches all the non-optional nodes of the ");
			T("Find Pattern (and possibly some of the optional nodes). ");
			T("Each optional node in the Find Pattern can match at most ");
			T("one parse-tree node.");
			P();

			T("For a parse-tree node to match, it must match all the ");
			T("features given in the corresponding pattern node. ");
			T("If the pattern node has children, all the children of the ");
			T("parse-tree node must match the children of the pattern ");
			T("node.");
			P();

			T("Features with the same name are compared, and they match ");
			T("if they have the same values. ");
			T("But if the feature value in the pattern begins with an ");
			T("exclamation mark (for example, \"!NP\"), the match is ");
			T("negated: the feature value in the parse-tree must ");
			B("not");
			T(" match the remaining pattern string. ");
			T("Note that the exclamation mark can be preceded by a ");
			T("backslash to escape this interpretation (for example ");
			T("\"\\!NP\").");
			P();

			T("Syntactic leaf nodes are indicated by a feature named ");
			T("\"node:type\" with value \"leaf\". ");
			T("A leaf node has either one child or more than one: each ");
			T("child represents a different morphological analysis for ");
			T("the word. ");
			T("Because the leaf children represent morphology ");
			T("alternatives, the matching algorithm works slightly ");
			T("differently: at least one (but not necessarily all) of ");
			T("the leaf-node children in the parse tree must match a ");
			T("leaf-node child in the pattern.");
			P();

			//**************************************************************

			B("Replace Pattern");
			P();

			T("After finding a matching sub-tree, the TreeTran engine ");
			T("replaces it with a new sub-tree specified by the Replace ");
			T("Pattern. ");
			T("The new sub-tree contains a copy of each node in the ");
			T("Replace Pattern. ");
			T("Optional nodes are only copied if they were matched by a ");
			T("corresponding node (one with the same label) in the Find ");
			T("Pattern.");
			P();

			T("When a Replace Pattern node is copied, it checks if a ");
			T("parse-tree node was matched by a corresponding node (same ");
			T("label) in the Find Pattern. ");
			T("If so, the features from the parse-tree node are copied ");
			T("to the new sub-tree node. ");
			T("Then the features from the Replace Pattern node are ");
			T("copied to the new sub-tree node, possibly replacing some ");
			T("of the feature values. ");
			T("Features with a blank value are deleted, and nodes with ");
			T("no features are deleted.");
			P();

			T("If a Replace Pattern node has children, they are copied ");
			T("to the new sub-tree node as its children. ");
			T("Otherwise, if a parse-tree node was matched by a ");
			T("corresponding node (same label) in the Find Pattern, the ");
			T("children of that parse-tree node are recursively copied ");
			T("as child branches of the new sub-tree node.");
			P();

			T("For syntactic leaf nodes, the child nodes (morphology ");
			T("alternatives) that were not matched by the Find Pattern ");
			T("are copied, in addition to any nodes specified by the ");
			T("Replace Pattern.");
			P();

			//**************************************************************
		}
		#endregion
		//******************************************************************

		// FORM EVENTS

		//******************************************************************
		#region [Load Event Handler]
		//******************************************************************
		/// <summary>
		/// Sets the form's help text.
		/// </summary>
		private void HelpForm_Load(object oSender,EventArgs oArgs)
		{
			try
			{
				SetHelpText();
			}
			catch (Exception oException)
			{
				ShowException(oException);
			}
		}
		#endregion
		//******************************************************************
		#region [Closing Event Handler]
		//******************************************************************
		/// <summary>
		/// Sets the active form back to the owner form.
		/// </summary>
		private void HelpForm_Closing(object oSender,CancelEventArgs oArgs)
		{
			try
			{
				if (Owner != null)
				{
					Owner.Activate();
					if (Owner.IsMdiContainer)
					{
						if (Owner.ActiveMdiChild != null)
						{
							Owner.ActiveMdiChild.Activate();
						}
					}
				}
			}
			catch (Exception oException)
			{
				ShowException(oException);
			}
		}
		#endregion
		//******************************************************************

		// CONTROL EVENTS

		//******************************************************************
		#region [RichTextBox KeyDown Event Handler]
		//******************************************************************
		/// <summary>
		/// Closes the form if the Escape key is pressed.
		/// </summary>
		private void moRichTextBox_KeyDown(object oSender,
			KeyEventArgs oArgs)
		{
			try
			{
				Debug.Assert(oArgs != null);

				if (oArgs.KeyData == Keys.Escape)
				{
					Close();
				}
			}
			catch (Exception oException)
			{
				ShowException(oException);
			}
		}
		#endregion
		//******************************************************************

		// ERROR HANDLING

		//******************************************************************
		#region [Static ShowException() and LogException() Methods]
		//******************************************************************
		/// <summary>
		/// Shows the user the message from the given exception object.
		/// </summary>
		private static void ShowException(Exception oException)
		{
			try
			{
				LogException(oException);
				MessageBox.Show(oException.Message,"Error");
			}
			catch
			{
				Debug.Fail("ShowException() failed.");
			}
		}
		//******************************************************************
		/// <summary>
		/// Logs the message from the given exception object.
		/// </summary>
		private static void LogException(Exception oException)
		{
			try
			{
				Debug.WriteLine("Error: " + oException.Message);
				Debug.WriteLine(oException.StackTrace);
			}
			catch
			{
				Debug.Fail("LogException() failed.");
			}
		}
		#endregion
		//******************************************************************
	}
}
//**************************************************************************
