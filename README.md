# Platformer 2D — Unity

> Projet réalisé dans le cadre du module **Développement Avancé** à l'IUT d'Orsay.

---

## Description

Jeu de plateforme 2D développé avec Unity, inspiré du style Mario.  
Le joueur doit traverser deux niveaux en évitant les ennemis, les pics et l'eau, tout en récupérant des pièces et des points de vie afin d'atteindre la sortie.

---

## Fonctionnalités implémentées

| Catégorie | Fonctionnalités |
|---|---|
| **Joueur** | Déplacement, saut, escalade d'échelles |
| **Animations** | Idle, Run, Climb, Death |
| **Caméra** | Caméra dynamique avec Cinemachine (State-Driven) |
| **Obstacles** | Ennemis, pics, eau |
| **Collectibles** | Pièces, points de vie |
| **Interface** | Score, HUD (vies), menu principal, menu pause |
| **Scènes** | Deux niveaux, écran de victoire, écran Game Over |
| **Audio** | Effets sonores, musique de fond |

---

## Contrôles

| Touche | Action |
|---|---|
| `←` / `→` | Déplacement |
| `↑` / `↓` | Monter/descendre une échelle |
| `Espace` | Saut |
| `Échap` | Pause |

---

## Build

Le build du jeu se trouve dans le dossier :

```
Release/
```

---

## Technologies utilisées

- **Unity** (Universal 2D)
- **C#**
- **Cinemachine** — caméra dynamique
- **TextMeshPro** — interface utilisateur
- **Unity Input System** — gestion des entrées
- **Assets** : [Kenney.nl — New Platformer Pack](https://kenney.nl/assets/new-platformer-pack) (licence CC0)

---

## Structure du projet

```
Assets/
├── Animations/
│   └── Player/
│   └── Pickups/
│   └── Enemy/
├── Audio/
│   └── Music/
├── Input System/
├── Materials/
├── Prefabs/
├── Scenes/
├── Scripts/
├── Sprites/
└── Tiles/
    ├── Background/
    └── Platforms/
```

---

## Fonctionnalités bonus

Aucune fonctionnalité bonus implémentée.

---

## Auteur

Mohamed Jadid — BUT Informatique, Groupe 6B-1, IUT d'Orsay
