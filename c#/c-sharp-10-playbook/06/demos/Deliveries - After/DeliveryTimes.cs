﻿namespace Pluralsight.CShPlaybook.NullValues;
public class DeliveryTimes
{
	// NB. Code relies on this list being sorted by increasing time
	// and containing at least one time
	List<TimeOnly> _deliveryTimes = new()
	{
		TimeOnly.Parse("08:30"),
		TimeOnly.Parse("09:00"),
		TimeOnly.Parse("12:15"),
		TimeOnly.Parse("13:00"),
		TimeOnly.Parse("15:20"),
	};
	public TimeOnly GetLastDeliveryTime() => _deliveryTimes[^1];
	public TimeOnly? GetNextDeliveryTime(TimeOnly timeNow)
	{
//		return  _deliveryTimes.FirstOrDefault(time => time >= timeNow); //won't work here!
        int index = _deliveryTimes.FindIndex(time => time >= timeNow);
		return index >= 0 ? _deliveryTimes[index] : null;
	}
	public bool IsDeliveryExpectedWithin30Mins(TimeOnly timeNow)
	{
		TimeOnly? nextDelivery = GetNextDeliveryTime(timeNow);
        if (nextDelivery == null)
            return false;
        TimeOnly nextDeliveryDefinite = nextDelivery.Value;
        return (nextDeliveryDefinite - timeNow).TotalMinutes <= 30;
        //		return nextDelivery != null && (nextDelivery.Value - timeNow).TotalMinutes <= 30;
    }

}