//Szenzor
public override string ToString()
{
	return string.Format("{0} ({1}; {2})",
		Aktiv ? "On" : "Off",
		Pozicio.x, Pozicio.y);
}

//Homero
public override string ToString()
{
	return string.Format("Hőmérő: {0}, A:{1} - F{2}",
		base.ToString(), AlsoHatar, FelsoHatar);
}