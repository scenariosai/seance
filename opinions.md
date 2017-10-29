# Goldschmidt Csaba összefoglalója a brainfactory konkurrens megoldásokról:

Alább egy ki összefoglaló mindarról, ami kipróbáltam.
Elöljáróban anyit, hogy ezek közül a programok közül (rapidminer, azure, alteryx, h2o) szerintem egyik se az, amire nekünk kell. Jól tudnak CSV vagy bármi más alapú szöveges cuccot feldolgozni, de az image classification, segmentation nem ezeknek a feladata.

### Rapidminer (Desktop app):
Nagyon jó a felülete. Az ablakok rendezhetőek mint a VisualStudióban. Ez az amit elsőre várok egy progitól, ha kinyitom.
Adatot rengeteg félét lehet importálni. A beimportált adatot a "főablakba" draggelve már el is lehet kezdeni a melót, és kb végigvezet az egyes lépéseken - a képernyő alsó sávjában "hint"-et ad, hogy szerinte mi a következő lépés.
A helpje egész jó, a tutorial videók érthetőek, rövidek, használhatóak.
Egy halom statisztikai outputja van, ami biztos nagy segítség annak aki ebben a témában dolgozik.
Az egyetlen probléma, ami belefutottam, az a kis operatorok input/output node-jainak az elnevezése. Mintha a **** _(cenzúrázva)_ csinálta volna. 
Exa, Ori, Unm stb. Ezekből találd ki, hogy mi a kimenet.
https://d2.alternativeto.net/dist/s/81ef28d0-0640-e011-8d53-0200d897d049_1_full.jpeg?format=jpg&width=1600&height=1600&mode=min&upscale=false
Erre az unreal engine BluePrint-je fényévekkel jobb megoldást kínál (szinte mindenre, ha van időd akkor youtube is nézz meg pár videót):
https://answers.unrealengine.com/storage/temp/24917-rotate90degrees.png
itt színekkel is jelzik, hogy mi-mivel köthető össze, és jól látható a kis fehér nyilakkal, hogy mi a folyamat menete.


### Azure:
Bevallom nem sokat foglalkoztam vele.
Számomra az egésznek olyan "a microsoft összebaszott valamit, hogy nekik is legyen ilyen" hangulata volt.
Fogalmad sincs, hogy az egyes operatorok input node-jai mit várnak, a hibavisszajelzés kb nulla.
Végül egy template használatával akartam egy mnist-et futtatni, de fogalmam sincs, hogy lefutott-e vagy sem, mert a run megnyomására nem történt semmi (persze az is lehet, hogy csak rossz böngészővel próbáltam)
Az adatok megtekintése kb annyi, hogy elkezdi letölteni, aztán oldd meg ahogy akarod.
Ezt az egész böngészős vonalat ejteném, mert bár lehet ez a trendi manapság, de szerintem ez csak szopást jelent.
Persze ha cuccnak a felhőben kell futnia, akkor érdemes lehet elgondolkozni, de..... Az egész design-ja számomra uncsi volt és használhatatlan.
Ordít róla, hogy ha ezt használni akarod, akkor elsőnek RTFM plusz gyémántdiploma

### Alteryx:
Ezt már nem töltöttem le. Ránézésre ugyanaz mint a Rapidminer.
Annyit láttam még benne, hogy támogatja az R nyelvet, és tudsz is benne fejleszteni.

### H2O:
így kezdem JAVA
akarod, hogy folytassam? :)
Ahogy láttam, pythonos cuccot is tud valahogy futtani, más kérdés, hogy az egyetlen imageclassification tutorial is 28x28-as képeket olvasott be CSV file-ból (csv minden sora 784 értékkel, mint a MNIST)
Na ettől az ökoszisztémától biztos nem akarnék függeni.

Amit hiányoltam elsőre mindből, az a fullscreen mód és a könnyű navigálás (még a rapidminer is scrollbar-t használ, ami azért vérciki 2017-ben)
A fullscreen-hez én a maya hotbox megoldását úgy ahogy van vinném. Dolgozam eleget maya-ban, hogy tudjam mennyire király. (ez a progriban a space lenyomására jön elő)https://www.youtube.com/watch?v=o2FB6UIK1rc

### Megjegyzések
Na még annyit, hogy Unreal Engine-ben én eleget mókoltam, hogy tudjam, komplex feladatot csak kódolással lehet megoldani.
Nincs az a node kötögető rendszer ami egy bizonyos méret felett átlátható marad. Mondjuk Unreal-ben is egész ügyesen oldották azért ezt a problémát.
És a Rapidminer-ben itt-ott egész jól kicselezték. Pl a CrossValidation operator belül tovább építhető. Ezt tetszik.
https://www.youtube.com/watch?v=Hw3tVDZ4Pmo&list=PLssWC2d9JhOZLbQNZ80uOxLypglgWqbJA&index=8
