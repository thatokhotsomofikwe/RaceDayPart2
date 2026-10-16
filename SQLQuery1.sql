USE RaceDayDB;
GO

SELECT
    name AS ConstraintName,
    CAST(definition AS VARCHAR(MAX)) AS FullDefinition
FROM sys.check_constraints
WHERE name IN ('CK_Events_EventType', 'CK_Events_Status');