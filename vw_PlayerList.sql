CREATE VIEW [dbo].[vw_PlayerList]
	AS 	 
	SELECT
	p.Id
	,p.PlayerName as [Name]	
	,cast( sum(ph.win) as varchar(4)) + '/' +cast( sum(ph.Lose) as varchar(4)) as [Win/Lose]
	FROM [Players] p 
	left join (
	Select playerID, 
	Case Result when 'Win' then 1 else 0 end [win],
	Case Result when 'Lose' then 1 else 0 end [lose] 
	from [PlayerHistory]) ph
	on ph.PlayerID = p.Id
	Group by p.PlayerName ,p.id

