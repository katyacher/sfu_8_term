sudo -i -u postgres
createuser --interactive
su sfu
psql -U sfu -d sfu -f create_db.sql
