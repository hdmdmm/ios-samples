﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
[MonoTouch.Foundation.Register("AlertsViewController")]
public partial class AlertsViewController {
	
	#pragma warning disable 0169
	[MonoTouch.Foundation.Connect("view")]
	private MonoTouch.UIKit.UITableView view {
		get {
			return ((MonoTouch.UIKit.UITableView)(this.GetNativeField("view")));
		}
		set {
			this.SetNativeField("view", value);
		}
	}
}
