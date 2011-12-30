
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D
{
	public partial class AddPathDialog
	{
		private global::Gtk.FileChooserWidget file_chooser_widget;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.AddPathDialog
			this.Name = "MonoDevelop.D.AddPathDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add Path");
			this.Modal = true;
			// Internal child MonoDevelop.D.AddPathDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.file_chooser_widget = new global::Gtk.FileChooserWidget (((global::Gtk.FileChooserAction)(0)));
			this.file_chooser_widget.Name = "file_chooser_widget";
			this.file_chooser_widget.ShowHidden = true;
			w1.Add (this.file_chooser_widget);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.file_chooser_widget]));
			w2.Position = 0;
			// Internal child MonoDevelop.D.AddPathDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 6;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 649;
			this.DefaultHeight = 436;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnCancelButtonClick);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnOkButtonClick);
		}
	}
}
