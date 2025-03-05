# 7-Segment-Anzeige in Unity

## Über das Projekt
Dieses Unity-Projekt implementiert eine digitale 7-Segment-Anzeige, die die Zahlen 0-9 darstellen kann. Die Anzeige wird durch ein Skript gesteuert, das die Segmente entsprechend rotiert.

## Features
- Anzeige der Zahlen 0 bis 9 mit einer 7-Segment-Darstellung
- Animierte Rotation der Segmente
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
        Anzeige.unity         # Hauptszene mit der Anzeige
```

## Steuerung
- Steuerung funktioniert über Numpad

## Bekannte Probleme & Fehlerbehebung
- Falls die Segmente nicht korrekt ausgerichtet sind, überprüfe die Start-Rotationen im `SevenSegmentDisplay.cs`.
- Falls die Animationen nicht korrekt ablaufen, stelle sicher, dass die Rotation in der Methode `RotateSegment()` korrekt gesetzt ist.

## Autor
Erstellt von Gabriel Wagner 3BHITS


