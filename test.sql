/*
 Navicat Premium Data Transfer

 Source Server         : localhost-root-root
 Source Server Type    : MySQL
 Source Server Version : 50731
 Source Host           : localhost:3306
 Source Schema         : test

 Target Server Type    : MySQL
 Target Server Version : 50731
 File Encoding         : 65001

 Date: 15/04/2023 23:18:09
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `sNo` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `sName` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `age` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`sNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('0', '0', NULL);
INSERT INTO `student` VALUES ('123', 'asd', 31);

-- ----------------------------
-- Table structure for t_sys_user
-- ----------------------------
DROP TABLE IF EXISTS `t_sys_user`;
CREATE TABLE `t_sys_user`  (
  `id` int(64) NOT NULL,
  `username` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `password` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `nick_name` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_sys_user
-- ----------------------------

-- ----------------------------
-- Table structure for user_info
-- ----------------------------
DROP TABLE IF EXISTS `user_info`;
CREATE TABLE `user_info`  (
  `id` bigint(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `name` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '姓名',
  `age` int(11) NULL DEFAULT NULL COMMENT '年龄',
  `skill` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '技能',
  `evaluate` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '评价',
  `fraction` bigint(11) NULL DEFAULT NULL COMMENT '分数',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '学生信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user_info
-- ----------------------------
INSERT INTO `user_info` VALUES (1, '小明', 20, '画画', '该学生在画画方面有一定天赋', 89);
INSERT INTO `user_info` VALUES (2, '小兰', 19, '游戏', '近期该学生由于游戏的原因导致分数降低了', 64);
INSERT INTO `user_info` VALUES (3, '张张', 18, '英语', '近期该学生参加英语比赛获得二等奖', 90);
INSERT INTO `user_info` VALUES (4, '大黄', 20, '体育', '该学生近期由于参加篮球比赛,导致脚伤', 76);
INSERT INTO `user_info` VALUES (5, '大白', 17, '绘画', '该学生参加美术大赛获得三等奖', 77);
INSERT INTO `user_info` VALUES (7, '小龙', 18, 'JAVA', '该学生是一个在改BUG的码农', 59);
INSERT INTO `user_info` VALUES (9, 'Sans', 18, '睡觉', 'Sans是一个爱睡觉,并且身材较矮骨骼巨大的骷髅小胖子', 60);
INSERT INTO `user_info` VALUES (10, 'papyrus', 18, 'JAVA', 'Papyrus是一个讲话大声、个性张扬的骷髅，给人自信、有魅力的骷髅小瘦子', 58);
INSERT INTO `user_info` VALUES (11, '删除数据1', 3, '画肖像', NULL, 61);
INSERT INTO `user_info` VALUES (12, '删除数据2', 3, NULL, NULL, 61);
INSERT INTO `user_info` VALUES (13, '删除数据3', 3, NULL, NULL, 61);
INSERT INTO `user_info` VALUES (14, '删除数据4', 5, '删除', NULL, 10);
INSERT INTO `user_info` VALUES (15, '删除数据5', 6, '删除', NULL, 10);

SET FOREIGN_KEY_CHECKS = 1;
