-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema TypicalUniversityModel
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema TypicalUniversityModel
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `TypicalUniversityModel` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `TypicalUniversityModel` ;

-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Faculties` (
  `FacultyId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`FacultyId`)  COMMENT '',
  UNIQUE INDEX `FacultyId_UNIQUE` (`FacultyId` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Departments` (
  `DepartmentId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Faculties_FacultyId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`DepartmentId`)  COMMENT '',
  INDEX `fk_Departments_Faculties_idx` (`Faculties_FacultyId` ASC)  COMMENT '',
  CONSTRAINT `fk_Departments_Faculties`
    FOREIGN KEY (`Faculties_FacultyId`)
    REFERENCES `TypicalUniversityModel`.`Faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Proffessors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Proffessors` (
  `ProffessorId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Departments_DepartmentId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`ProffessorId`)  COMMENT '',
  UNIQUE INDEX `ProffessorId_UNIQUE` (`ProffessorId` ASC)  COMMENT '',
  INDEX `fk_Proffessors_Departments1_idx` (`Departments_DepartmentId` ASC)  COMMENT '',
  CONSTRAINT `fk_Proffessors_Departments1`
    FOREIGN KEY (`Departments_DepartmentId`)
    REFERENCES `TypicalUniversityModel`.`Departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Titles` (
  `TitleId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`TitleId`)  COMMENT '',
  UNIQUE INDEX `TitleId_UNIQUE` (`TitleId` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Proffessors_Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Proffessors_Titles` (
  `Proffessors_ProffessorId` INT NOT NULL COMMENT '',
  `Titles_TitleId` INT NOT NULL COMMENT '',
  INDEX `fk_Proffessors_Titles_Proffessors1_idx` (`Proffessors_ProffessorId` ASC)  COMMENT '',
  INDEX `fk_Proffessors_Titles_Titles1_idx` (`Titles_TitleId` ASC)  COMMENT '',
  PRIMARY KEY (`Proffessors_ProffessorId`, `Titles_TitleId`)  COMMENT '',
  CONSTRAINT `fk_Proffessors_Titles_Proffessors1`
    FOREIGN KEY (`Proffessors_ProffessorId`)
    REFERENCES `TypicalUniversityModel`.`Proffessors` (`ProffessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Proffessors_Titles_Titles1`
    FOREIGN KEY (`Titles_TitleId`)
    REFERENCES `TypicalUniversityModel`.`Titles` (`TitleId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Courses` (
  `CourseId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Proffessors_ProffessorId` INT NOT NULL COMMENT '',
  `Departments_DepartmentId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`CourseId`)  COMMENT '',
  UNIQUE INDEX `CourseId_UNIQUE` (`CourseId` ASC)  COMMENT '',
  INDEX `fk_Courses_Proffessors1_idx` (`Proffessors_ProffessorId` ASC)  COMMENT '',
  INDEX `fk_Courses_Departments1_idx` (`Departments_DepartmentId` ASC)  COMMENT '',
  CONSTRAINT `fk_Courses_Proffessors1`
    FOREIGN KEY (`Proffessors_ProffessorId`)
    REFERENCES `TypicalUniversityModel`.`Proffessors` (`ProffessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_Departments1`
    FOREIGN KEY (`Departments_DepartmentId`)
    REFERENCES `TypicalUniversityModel`.`Departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Students` (
  `StudentId` INT NOT NULL COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Faculties_FacultyId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`StudentId`)  COMMENT '',
  INDEX `fk_Students_Faculties1_idx` (`Faculties_FacultyId` ASC)  COMMENT '',
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`Faculties_FacultyId`)
    REFERENCES `TypicalUniversityModel`.`Faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TypicalUniversityModel`.`Courses_Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`Courses_Students` (
  `Students_StudentId` INT NOT NULL COMMENT '',
  `Courses_CourseId` INT NOT NULL COMMENT '',
  INDEX `fk_Courses_Students_Students1_idx` (`Students_StudentId` ASC)  COMMENT '',
  INDEX `fk_Courses_Students_Courses1_idx` (`Courses_CourseId` ASC)  COMMENT '',
  PRIMARY KEY (`Students_StudentId`, `Courses_CourseId`)  COMMENT '',
  CONSTRAINT `fk_Courses_Students_Students1`
    FOREIGN KEY (`Students_StudentId`)
    REFERENCES `TypicalUniversityModel`.`Students` (`StudentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_Students_Courses1`
    FOREIGN KEY (`Courses_CourseId`)
    REFERENCES `TypicalUniversityModel`.`Courses` (`CourseId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `TypicalUniversityModel` ;

-- -----------------------------------------------------
-- Placeholder table for view `TypicalUniversityModel`.`view1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TypicalUniversityModel`.`view1` (`id` INT);

-- -----------------------------------------------------
-- View `TypicalUniversityModel`.`view1`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TypicalUniversityModel`.`view1`;
USE `TypicalUniversityModel`;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
