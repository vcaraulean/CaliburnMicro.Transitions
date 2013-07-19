using System;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CaliburnMicro.Transitions
{
	public class ShellViewModel : Screen, IShell
	{
		private readonly Func<ZoneViewModel> zoneCreator;
		private ZoneViewModel zone1;
		private ZoneViewModel zone2;
		private ZoneViewModel zone3;
		private ZoneViewModel zone4;

		public ShellViewModel(Func<ZoneViewModel> zoneCreator)
		{
			this.zoneCreator = zoneCreator;
			DisplayName = "Trying Caliburn.Micro and TransitioningContentControl from mahApps.Metro";
		}

		public async void StartTransitions()
		{
			if (Zone1 != null)
			{
				Zone1 = null;
				Zone2 = null;
				Zone3 = null;
				Zone4 = null;
				await Task.Delay(2000);
			}

			Zone1 = zoneCreator();
			Zone1.ZoneNumber = 1;
			await Task.Delay(700);
			Zone2 = zoneCreator();
			Zone2.ZoneNumber = 2;
			await Task.Delay(700);
			Zone3 = zoneCreator();
			Zone3.ZoneNumber = 3;
			await Task.Delay(700);
			Zone4 = zoneCreator();
			Zone4.ZoneNumber = 4;
		}

		public ZoneViewModel Zone1
		{
			get { return zone1; }
			set
			{
				zone1 = value;
				NotifyOfPropertyChange(() => Zone1);
			}
		}

		public ZoneViewModel Zone2
		{
			get { return zone2; }
			set
			{
				zone2 = value;
				NotifyOfPropertyChange(() => Zone2);
			}
		}

		public ZoneViewModel Zone3
		{
			get { return zone3; }
			set
			{
				zone3 = value;
				NotifyOfPropertyChange(() => Zone3);
			}
		}

		public ZoneViewModel Zone4
		{
			get { return zone4; }
			set
			{
				zone4 = value;
				NotifyOfPropertyChange(() => Zone4);
			}
		}
	}
}