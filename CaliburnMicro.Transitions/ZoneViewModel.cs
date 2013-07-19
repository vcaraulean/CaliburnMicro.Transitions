using Caliburn.Micro;

namespace CaliburnMicro.Transitions
{
	public class ZoneViewModel : Screen
	{
		private int zoneNumber;
		public int ZoneNumber
		{
			get { return zoneNumber; }
			set
			{
				if (value == zoneNumber) return;
				zoneNumber = value;
				NotifyOfPropertyChange(() => ZoneNumber);
			}
		}
	}
}