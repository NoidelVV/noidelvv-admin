# NoidelVV Admin
NoidelVV Admin è un software creato per gestire tramite desktop alcune parti di NoidelVV:
- Generazione e decodifica password per classe (obsoleto)
- Generazione dei crediti per i membri di NoidelVV
- Generazione fogli password da distribuire nelle classi (obsoleto)
- Gestione di VVAbbigliamento (2014)
- Gestione di VVFoto (2014)

# Descrizione files
Di seguito viene fornita una descrizione dei file contenuti nel progetto.
### GenCrediti.cs
Genera un file .docx con i crediti per i membri di NoidelVV partendo da un elenco in formato .xlsx, che deve contenere i dati della persona e le ore di partecipazione.
### Login.cs
Login per l'accesso al software tramite il framework di SSO Corp.
### Main.cs
Form Container per tutti gli altri.
### PassGen.cs
Classe per la generazione delle password per i primi sistemi di NoidelVV (obsoleto)
### Password.cs
Genera un file .docx con tutte le password delle classi partendo da un file .xlsx
### Splash.cs
SplashScreen
### VVAbbigliamento.cs
Gestione di VVAbbigliamento
### VVFoto.cs
Gestione di VVFoto: visualizzazione ordini e stato del pagamento
