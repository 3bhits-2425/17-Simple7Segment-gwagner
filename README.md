# 7-Segment-Anzeige in Unity

## Über das Projekt
Dieses Unity-Projekt implementiert eine digitale 7-Segment-Anzeige, die die Zahlen 0-9 darstellen kann. Die Anzeige wird durch ein Skript gesteuert, das die Segmente entsprechend rotiert.

## Features
- Anzeige der Zahlen 0 bis 9 mit einer 7-Segment-Darstellung
- Rotation der Segmente (über Euler)
- Steuerung per NumPad

## Verwendete Technologien
- Unity Engine
- C# für die Skriptsteuerung

## Projektstruktur
```
Assets/
    Skripts/
        SevenSegmentDisplay.cs  # Steuerung der Segmentanzeige
    Scenes/
        SingleSegment.unity         # Hauptszene mit der Anzeige
		MultipleSegment.unity		# 2. Szene für mehrere Anzeigen
	Prefabs/
		7SegmentAnzeige.prefab		#Hauptanzeige mit den 7 Segmenten + Manager
```

## Steuerung
- Steuerung funktioniert über Numpad

## Bekannte Probleme & Fehlerbehebung
- Falls die Segmente nicht korrekt ausgerichtet sind, überprüfe die Start-Rotationen im `SevenSegmentDisplay.cs`.
- Falls die Rotationen nicht korrekt ablaufen, stelle sicher, dass sie in der Methode `RotateSegment()` korrekt gesetzt ist.

## Autor
Erstellt von Gabriel Wagner 3BHITS

https://github.com/user-attachments/assets/19ddb189-c99e-4b5a-b92f-9b29dfa886f0
