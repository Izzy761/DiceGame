CREATE VIEW [dbo].[vw_PlayerHistory]
	AS 
	SELECT 
	p.id
	,p.PlayerName as [Name]
	,Count(ph.Roll) as [Rolls]	
	,cast(sum(phr.win) as varchar(4)) + '/' +cast(sum(phr.Lose) as varchar(4)) as [Win/Lose]
	FROM [Players] p 
	left join [PlayerHistory] ph
	on ph.PlayerID = p.Id
	left join (
	Select playerID, 
	Case Result when 'Win' then 1 else 0 end [win],
	Case Result when 'Lose' then 1 else 0 end [lose] 
	from [PlayerHistory]) phr
	on phr.PlayerID = p.Id
	Group by p.PlayerName ,p.id
	
