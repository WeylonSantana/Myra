/* Generated by MyraPad at 9/19/2024 11:10:13 AM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using AssetManagementBase;

#if STRIDE
using Stride.Core.Mathematics;
#elif PLATFORM_AGNOSTIC
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#else
// MonoGame/FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endif

namespace MyraPad.UI
{
	partial class MainForm: VerticalStackPanel
	{
		private void BuildUI()
		{
			_menuFileNew = new MenuItem();
			_menuFileNew.Text = "&New";
			_menuFileNew.ShortcutText = "Ctrl+N";
			_menuFileNew.Id = "_menuFileNew";

			_menuFileOpen = new MenuItem();
			_menuFileOpen.Text = "&Open";
			_menuFileOpen.ShortcutText = "Ctrl+O";
			_menuFileOpen.Id = "_menuFileOpen";

			_menuFileReload = new MenuItem();
			_menuFileReload.Text = "&Reload";
			_menuFileReload.ShortcutText = "Ctrl+R";
			_menuFileReload.Id = "_menuFileReload";

			_menuFileSave = new MenuItem();
			_menuFileSave.Text = "&Save";
			_menuFileSave.ShortcutText = "Ctrl+S";
			_menuFileSave.Id = "_menuFileSave";

			_menuFileSaveAs = new MenuItem();
			_menuFileSaveAs.Text = "Save &As...";
			_menuFileSaveAs.Id = "_menuFileSaveAs";

			_menuFileExportToCS = new MenuItem();
			_menuFileExportToCS.Text = "&Export To C#...";
			_menuFileExportToCS.ShortcutText = "Ctrl+E";
			_menuFileExportToCS.Id = "_menuFileExportToCS";

			var menuSeparator1 = new MenuSeparator();

			_menuFileLoadStylesheet = new MenuItem();
			_menuFileLoadStylesheet.Text = "&Load Stylesheet";
			_menuFileLoadStylesheet.Id = "_menuFileLoadStylesheet";

			_menuFileResetStylesheet = new MenuItem();
			_menuFileResetStylesheet.Text = "Rese&t Stylesheet";
			_menuFileResetStylesheet.Id = "_menuFileResetStylesheet";

			var menuSeparator2 = new MenuSeparator();

			_menuFileDebugOptions = new MenuItem();
			_menuFileDebugOptions.Text = "&UI Debug Options";
			_menuFileDebugOptions.Id = "_menuFileDebugOptions";

			var menuSeparator3 = new MenuSeparator();

			_menuFileQuit = new MenuItem();
			_menuFileQuit.Text = "&Quit";
			_menuFileQuit.ShortcutText = "Ctrl+Q";
			_menuFileQuit.Id = "_menuFileQuit";

			_menuFile = new MenuItem();
			_menuFile.Text = "&File";
			_menuFile.Id = "_menuFile";
			_menuFile.Items.Add(_menuFileNew);
			_menuFile.Items.Add(_menuFileOpen);
			_menuFile.Items.Add(_menuFileReload);
			_menuFile.Items.Add(_menuFileSave);
			_menuFile.Items.Add(_menuFileSaveAs);
			_menuFile.Items.Add(_menuFileExportToCS);
			_menuFile.Items.Add(menuSeparator1);
			_menuFile.Items.Add(_menuFileLoadStylesheet);
			_menuFile.Items.Add(_menuFileResetStylesheet);
			_menuFile.Items.Add(menuSeparator2);
			_menuFile.Items.Add(_menuFileDebugOptions);
			_menuFile.Items.Add(menuSeparator3);
			_menuFile.Items.Add(_menuFileQuit);

			_menuItemSelectAll = new MenuItem();
			_menuItemSelectAll.Text = "Select &All";
			_menuItemSelectAll.ShortcutText = "Ctrl+A";
			_menuItemSelectAll.Id = "_menuItemSelectAll";

			_menuItemCopy = new MenuItem();
			_menuItemCopy.Text = "&Copy";
			_menuItemCopy.ShortcutText = "Ctrl+Insert, Ctrl+C";
			_menuItemCopy.Id = "_menuItemCopy";

			_menuItemPaste = new MenuItem();
			_menuItemPaste.Text = "&Paste";
			_menuItemPaste.ShortcutText = "Shift+Insert, Ctrl+V";
			_menuItemPaste.Id = "_menuItemPaste";

			_menuItemCut = new MenuItem();
			_menuItemCut.Text = "Cu&t";
			_menuItemCut.ShortcutText = "Ctrl+X";
			_menuItemCut.Id = "_menuItemCut";

			_menuItemDuplicate = new MenuItem();
			_menuItemDuplicate.Text = "Duplicate";
			_menuItemDuplicate.ShortcutText = "Ctrl+D";
			_menuItemDuplicate.Id = "_menuItemDuplicate";

			var menuSeparator4 = new MenuSeparator();

			_menuEditFormatSource = new MenuItem();
			_menuEditFormatSource.Text = "&Format Source";
			_menuEditFormatSource.ShortcutText = "Ctrl+F";
			_menuEditFormatSource.Id = "_menuEditFormatSource";

			var menuItem1 = new MenuItem();
			menuItem1.Text = "&Edit";
			menuItem1.Items.Add(_menuItemSelectAll);
			menuItem1.Items.Add(_menuItemCopy);
			menuItem1.Items.Add(_menuItemPaste);
			menuItem1.Items.Add(_menuItemCut);
			menuItem1.Items.Add(_menuItemDuplicate);
			menuItem1.Items.Add(menuSeparator4);
			menuItem1.Items.Add(_menuEditFormatSource);

			_menuHelpAbout = new MenuItem();
			_menuHelpAbout.Text = "&About";
			_menuHelpAbout.Id = "_menuHelpAbout";

			var menuItem2 = new MenuItem();
			menuItem2.Text = "&Help";
			menuItem2.Items.Add(_menuHelpAbout);

			_mainMenu = new HorizontalMenu();
			_mainMenu.Id = "_mainMenu";
			_mainMenu.Items.Add(_menuFile);
			_mainMenu.Items.Add(menuItem1);
			_mainMenu.Items.Add(menuItem2);

			var horizontalSeparator1 = new HorizontalSeparator();

			_panelExplorer = new ScrollViewer();
			_panelExplorer.Id = "_panelExplorer";

			_projectHolder = new Panel();
			_projectHolder.Id = "_projectHolder";

			_textSource = new TextBox();
			_textSource.Multiline = true;
			_textSource.Wrap = true;
			_textSource.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_textSource.Id = "_textSource";

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.Content = _textSource;

			_leftSplitPane = new VerticalSplitPane();
			_leftSplitPane.Id = "_leftSplitPane";
			StackPanel.SetProportionType(_leftSplitPane, Myra.Graphics2D.UI.ProportionType.Fill);
			_leftSplitPane.Widgets.Add(_projectHolder);
			_leftSplitPane.Widgets.Add(scrollViewer1);

			var horizontalSeparator2 = new HorizontalSeparator();

			_textStatus = new Label();
			_textStatus.Text = "Reloading...";
			_textStatus.Id = "_textStatus";

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Widgets.Add(_leftSplitPane);
			verticalStackPanel1.Widgets.Add(horizontalSeparator2);
			verticalStackPanel1.Widgets.Add(_textStatus);

			var label1 = new Label();
			label1.Text = "Filter:";

			_textBoxFilter = new TextBox();
			_textBoxFilter.Id = "_textBoxFilter";
			StackPanel.SetProportionType(_textBoxFilter, Myra.Graphics2D.UI.ProportionType.Fill);

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 8;
			horizontalStackPanel1.Widgets.Add(label1);
			horizontalStackPanel1.Widgets.Add(_textBoxFilter);

			var horizontalSeparator3 = new HorizontalSeparator();

			_propertyGrid = new PropertyGrid();
			_propertyGrid.Id = "_propertyGrid";

			_propertyGridPane = new ScrollViewer();
			_propertyGridPane.Id = "_propertyGridPane";
			StackPanel.SetProportionType(_propertyGridPane, Myra.Graphics2D.UI.ProportionType.Fill);
			_propertyGridPane.Content = _propertyGrid;

			var horizontalSeparator4 = new HorizontalSeparator();

			_textLocation = new Label();
			_textLocation.Text = "Line: 1, Column: 2, Indent: 3";
			_textLocation.Id = "_textLocation";

			var verticalStackPanel2 = new VerticalStackPanel();
			verticalStackPanel2.Background = new SolidBrush("#000000FF");
			verticalStackPanel2.Widgets.Add(horizontalStackPanel1);
			verticalStackPanel2.Widgets.Add(horizontalSeparator3);
			verticalStackPanel2.Widgets.Add(_propertyGridPane);
			verticalStackPanel2.Widgets.Add(horizontalSeparator4);
			verticalStackPanel2.Widgets.Add(_textLocation);

			_topSplitPane = new HorizontalSplitPane();
			_topSplitPane.Id = "_topSplitPane";
			StackPanel.SetProportionType(_topSplitPane, Myra.Graphics2D.UI.ProportionType.Fill);
			_topSplitPane.Widgets.Add(_panelExplorer);
			_topSplitPane.Widgets.Add(verticalStackPanel1);
			_topSplitPane.Widgets.Add(verticalStackPanel2);

			
			Widgets.Add(_mainMenu);
			Widgets.Add(horizontalSeparator1);
			Widgets.Add(_topSplitPane);
		}

		
		public MenuItem _menuFileNew;
		public MenuItem _menuFileOpen;
		public MenuItem _menuFileReload;
		public MenuItem _menuFileSave;
		public MenuItem _menuFileSaveAs;
		public MenuItem _menuFileExportToCS;
		public MenuItem _menuFileLoadStylesheet;
		public MenuItem _menuFileResetStylesheet;
		public MenuItem _menuFileDebugOptions;
		public MenuItem _menuFileQuit;
		public MenuItem _menuFile;
		public MenuItem _menuItemSelectAll;
		public MenuItem _menuItemCopy;
		public MenuItem _menuItemPaste;
		public MenuItem _menuItemCut;
		public MenuItem _menuItemDuplicate;
		public MenuItem _menuEditFormatSource;
		public MenuItem _menuHelpAbout;
		public HorizontalMenu _mainMenu;
		public ScrollViewer _panelExplorer;
		public Panel _projectHolder;
		public TextBox _textSource;
		public VerticalSplitPane _leftSplitPane;
		public Label _textStatus;
		public TextBox _textBoxFilter;
		public PropertyGrid _propertyGrid;
		public ScrollViewer _propertyGridPane;
		public Label _textLocation;
		public HorizontalSplitPane _topSplitPane;
	}
}