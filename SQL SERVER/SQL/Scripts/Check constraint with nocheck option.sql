alter table TB_SAMPLE_TABLE
with nocheck
add constraint chk_TB_SAMPLE_TABLE_Gender
check(Gender like '[M|F]')