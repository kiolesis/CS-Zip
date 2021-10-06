static void Wypakuj() {

	string zipPath = @"C:\USER\Desktop\plik.zip";
	// Przypisanie do zmiennej lokalizacji pliku .zip

	string extractPath = @"C:\USER\Desktop\Wypakowane";
	// Przypisanie do zmiennej lokalizacji, gdzie nasze pliki mają zostać wypakowane

	ZipFile.ExtractToDirectoctory(zipPath, extractPath);
	// Metoda wykonawcza
}
