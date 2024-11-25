select * from Barco;

BEGIN TRAN --Executar antes para efetuar o Backup
ROLLBACK --Executar depois para voltar ao Backup

delete Barco