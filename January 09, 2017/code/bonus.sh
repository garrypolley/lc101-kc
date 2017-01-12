#!/usr/bin/env bash
# This file contains the bonus command for running a python server
# Python has a built in simple server for loading up local files.
# It is not secure and should NEVER be used in production.
python -m http.server

# Note this only runs because I've made it executable via:
# chmod a+x bonus.sh