﻿/// <binding AfterBuild="prod" />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
Grunt tasks: https://gruntjs.com/configuring-tasks
*/
console.log(`Node ${process.version}`); // node version
module.exports = function (grunt) {
    'use strict';
    const sass = require('node-sass'); // used in grunt-sass options, must be included in package.json

    grunt.loadNpmTasks('grunt-sass');
    grunt.loadNpmTasks('@lodder/grunt-postcss'); // grunt-postcss is retired, use @lodder/grunt-postcss
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        // Sass
        sass: {
            options: {
                implementation: sass,
                sourceMap: false, // Create source map
                outputStyle: 'nested' // Minify output with "compressed"
            },
            dist: {
                files: {
                    'wwwroot/lib/bootstrap/bootstrap.css': 'Styles/bootstrap/custom_bootstrap.scss',  // "destination": "source" (no arrays!)
                    'wwwroot/lib/fontawesome/fontawesome.css': 'Styles/fontawesome/fontawesome.scss',
                    'wwwroot/css/site.css': 'Styles/site/site.scss'
                }
            }
        },

        // Postcss
        postcss: {
            options: {
                // map: true, // inline source maps
                // or
                map: {
                    inline: false, // save all source maps as separate files...
                    annotation: 'wwwroot/css/maps/', // ...to the specified directory relative to the project root
                    sourcesContent: true // whether original contents (e.g. Sass sources) will be included to a sourcemap. 
                },

                processors: [
                    require('autoprefixer'), // add vendor prefixes
                    require('cssnano')() // minify the result
                ]
            },
            dist: {  // the dist object will hold information on where our CSS files should be read from and written to.
                // src: "css/*.css"
                //src: "css/bootstrap.css"
                //dest: "css/bootstrap.min.css" // if dest: is missing, src will be replaced
                files: {
                    'wwwroot/lib/bootstrap/bootstrap.min.css': 'wwwroot/lib/bootstrap/bootstrap.css',
                    'wwwroot/css/site.min.css': 'wwwroot/css/site.css',
                    'wwwroot/lib/fontawesome/fontawesome.min.css': 'wwwroot/lib/fontawesome/fontawesome.css'
                }
            }
        },

        uglify: {
            options: {
                sourceMap: false
                /* for debugging
                sourceMap: {
                    includeSources: true
                }*/
            },
            TempusDominusFactory: {
                files: {
                    'Scripts/Site.TempusDominusFactory.min.js': ['Scripts/Site.TempusDominusFactory.js']
                }
            },
            build: {
                files: {
                    'wwwroot/js/site.min.js': ['Scripts/Site.ModalForm.js', 'Scripts/Site.ShowPassword.js', 'node_modules/js-cookie/src/js.cookie.js']
                }
            }
        },
        concat: {
            js_nlog: {
                src: ['node_modules/jsnlog/jsnlog.min.js'],
                dest: 'wwwroot/lib/jsnlog/jsnlog.min.js',
                nonull: true
            },
            bootstrap_js_all: {
                src: ['node_modules/@popperjs/core/dist/umd/popper.min.js',
                    'node_modules/bootstrap/dist/js/bootstrap.min.js'
                    ],
                dest: 'wwwroot/lib/bootstrap/bootstrap-all.min.js',
                nonull: true
            },
            bootstrap_css_all: {
                src: ['wwwroot/lib/bootstrap/bootstrap.min.css'],
                dest: "wwwroot/lib/bootstrap/bootstrap.min.css",
                nonull: true
            },
            tempus_dominus_all_js: {
                src: ['node_modules/@eonasdan/tempus-dominus/dist/js/tempus-dominus.min.js',
                'node_modules/@eonasdan/tempus-dominus/dist/locales/de.js',
                'node_modules/@eonasdan/tempus-dominus/dist/plugins/bi-one.js',
                'Scripts/Site.TempusDominusFactory.min.js'],
                dest: 'wwwroot/lib/tempus-dominus/tempus-dominus.all.min.js',
                nonull: true
            },
            tempus_dominus_css: {
                src: ['node_modules/@eonasdan/tempus-dominus/dist/css/tempus-dominus.min.css'],
                dest: 'wwwroot/lib/tempus-dominus/tempus-dominus.min.css',
                nonull: true
            },
            dropzone_js: {
                src: ['node_modules/dropzone/dist/min/dropzone.min.js'],
                dest: 'wwwroot/lib/dropzone/dropzone.min.js',
                nonull: true
            },
            dropzone_css: {
                // Note: uglify is not compatible with ES6 (e.g. const instead of var)
                src: ['node_modules/dropzone/dist/min/basic.min.css', 'node_modules/dropzone/dist/min/dropzone.min.css'],
                dest: 'wwwroot/lib/dropzone/dropzone.min.css',
                nonull: true
            }
        },

        copy: {
            font_awesome_fonts: {
                files: [
                    { cwd: 'node_modules/@fortawesome/fontawesome-free/webfonts/', expand: 'true', src: '**/*', dest: 'wwwroot/webfonts/' }
                ]
            },
            css_images: {
                files: [
                    { cwd: 'Styles/Images/', expand: 'true', src: '**/*', dest: 'wwwroot/css/images/' }
                ]
            }
        },

        // Watch
        watch: {
            css: {
                files: ['Styles/**/*.scss'],
                tasks: ['sass', 'postcss'],
                options: {
                    spawn: false
                }
            }
        }
    });

    grunt.registerTask('dev', ['watch']);
    grunt.registerTask('prod', ['sass', 'postcss', 'uglify', 'concat', 'copy']);
};