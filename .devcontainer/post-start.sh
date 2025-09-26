#!/bin/sh

# pull and start the database
docker run -d -p 1433:1433 marcelv/globoticket-default-db