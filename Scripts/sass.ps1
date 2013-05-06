param (
	$action = "watch",
	$project = "BootstrapMVC"
	)

$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
$root = split-path -parent $scriptPath
$folder = "$root\$project"

pushd $root
try {
	bundle install
	bundle exec compass $action $project
} finally {
	popd
}