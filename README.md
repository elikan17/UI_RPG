# UI_RPG

Learning project for a school programming course.

1. MANTOŠANA - No Character klases manto Player un Enemy, kā arī no Enemy manto InfectionEnemy un CritEnemy. Sword klase manto no Weapon, kā arī PoisonSword un CritSword manto no Sword klases.
2. ENKAPSULĀCIJA - Character klasē tiek izmantoti getter un setter. Piemēram, Health izmanto getter un setter, lai veselības vērtība nekad nebūtu negatīva, un CharName izmanto getter, lai nepieļautu tiešu modifikāciju.
3. POLIMORFISMS -
Override: Death() metode tiek override Player un Enemy klasēs, jo tās darbība atšķiras. Attack() tiek override dažādos ienaidniekos, lai mainītu uzbrukuma veidu. GetDamage() tiek override dažādās ieroču klasēs, lai noteiktu atšķirīgu uzbrukšanas veidu/
Overload: Character klasē ir divas TakeDamage() metodes ar dažādiem parametriem (float damage un Weapon).
4. ABSTRAKCIJA - Weapon ir abstrakta klase ar abstraktu metodi GetDamage() un parastu metodi SelectedWeaponName(). No šīs abstraktās klases tieši mantotas vismaz divas klases: Sword un Bow.

Papilduzdevumi:
1. Spēle ir 3 dažādi pretinieki ar dažādiem uzbrukumi veidiem.
2. Spēlē ir 4 dažādi ieroči, no kuriem trīs atšķiras ar uzbrukuma veidu.
3. Pievienoju vizuālo noformējumu, kur tiek parādīts attēls ar pašreizējo pretinieku, kā arī kad pretinieks nomirst, tiek parādīts particle.
