public class CacheDialect extends Cache71Dialect {

    public CacheDialect() {
        super();
        this.registerColumnType(Types.BOOLEAN, "bit");
    }

    @Override
    public MultiTableBulkIdStrategy getDefaultMultiTableBulkIdStrategy() {
        return new LocalTemporaryTableBulkIdStrategy(
                new IdTableSupportStandardImpl() {
                    @Override
                    public String generateIdTableName(String baseName) {
                        final String name = super.generateIdTableName( baseName );
                        return name.length() > 25 ? name.substring( 1, 25 ) : name;
                    }

                    @Override
                    public String getCreateIdTableCommand() {
                        return "create global temporary table";
                    }
                },
                AfterUseAction.DROP,
                null
        );

    }

}
